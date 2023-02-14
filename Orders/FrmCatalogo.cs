using Google.Protobuf.WellKnownTypes;
using Orders.Classes;
using Orders.ClassesDAO;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Orders
{
    public partial class FrmCatalogo : Form
    {
        ClienteDAO cliDAO = new ClienteDAO();
        CategoriaDAO catDAO = new CategoriaDAO();
        ProdutoDAO prodDAO = new ProdutoDAO();
        List<string> listaitens = new List<string>();

        public Dictionary<object, Tuple<int, string>> Params = new Dictionary<object, Tuple<int, string>>();
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {


            Conexao.criar_Conexao();
           // var orientation = SystemInformation.ScreenOrientation;
            //int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            //int screenHeight = Screen.PrimaryScreen.Bounds.Height;



            //  if (orientation.ToString() == "Angle0" || orientation.ToString() == "Angle90")
            // {
            //     int x = screenWidth - (screenWidth * 30 / 100), y = screenHeight - (screenHeight * 30 / 100);
            //   flowLayoutPanel1.Size = new Size(x, y);
            //   flowLayoutPanel1.Location = new Point((screenWidth / 2) - (x / 2), (screenHeight / 2) - (y / 2));

            //   flowLayoutPanel2.Location = new Point(Convert.ToInt32(flowLayoutPanel1.Size.Width *  21.785/100 + flowLayoutPanel1.Size.Width), flowLayoutPanel1.Location.Y);
            //    flowLayoutPanel2.Width =  (screenWidth * 30 / 100)/2 - 16;
            //    flowLayoutPanel2.Height = y;
            // btnProvisorio.Location = new Point(200, 300);
            //   }
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            catDAO.ListarCategorias();
            AcrescentarButtons();
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
           
            Tuple<int, string> value;
            if (Params.TryGetValue(sender, out value))
            {
                // MessageBox.Show(value.Item1.ToString() + ": " + value.Item2);

                catDAO.Listacategoria = null;
                if (prodDAO.Listaproduto == null)
                {
                    prodDAO.VerificaNOMEPESQ(value.Item2);
                    AcrescentarButtons();
                }
                else
                {
                    if (!listaitens.Contains(value.Item2.ToString()))
                    {
                        Itemcontrol item = new Itemcontrol();
                        item.LblItem.Text = value.Item2.ToString();
                        FlpItens.Controls.Add(item);
                        BtnFinalizarpedido.Visible = true;
                        listaitens.Add(value.Item2.ToString());
                        //  flowLayoutPanel2.Controls.IndexOf(item.label1);
                    }
                }

            }
            else
            {
                //se fizer a adição de pedidos por aqui, terá de ser feito uma tratativa para não cadastrar produtos com nome igual ao de categorias

                MessageBox.Show(sender.ToString() + " not found.");
            }
        }

        private void AcrescentarButtons()
        {
            var orientation = SystemInformation.ScreenOrientation;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            //fazer tratativa de erros caso não exista categoria cadastrada ainda

            if (catDAO.Listacategoria != null)
            {
                int qtdcategorias = catDAO.Listacategoria.Rows.Count;

                for (int i = 0; i < qtdcategorias; i++)
                {
                    // Create a Button object 
                    Button dynamicButton = new Button();

                    // Set Button properties
                    int x = screenWidth - (screenWidth * 30 / 100), y = screenHeight - (screenHeight * 30 / 100);

                    if (orientation.ToString() == "Angle0")
                    {
                        dynamicButton.Width = (x / 5) - 10;
                        dynamicButton.Height = (y / 3);
                    }
                    else if (orientation.ToString() == "Angle90")
                    {
                        dynamicButton.Width = (x / 3) - 10;
                        dynamicButton.Height = (y / 5);
                    }


                    // dynamicButton.BackColor = Color.Red;
                    //dynamicButton.ForeColor = Color.Blue;
                    // dynamicButton.Location = new Point(20, 150);
                    dynamicButton.Text = catDAO.Listacategoria.Rows[i]["nome"].ToString();

                    try
                    {
                        dynamicButton.BackgroundImage = System.Drawing.Image.FromFile(catDAO.Listacategoria.Rows[i]["imagem"].ToString());
                        dynamicButton.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    catch
                    {

                    }
                    // dynamicButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\Uzann\\Pictures\\v54.png");

                    


                    // dynamicButton.Name = "DynamicButton";
                    // dynamicButton.Font = new Font("Georgia", 16);
                    // Add a Button Click Event handler
                    Params.Add(dynamicButton, new Tuple<int, string>(1, dynamicButton.Text));
                    dynamicButton.Click += DynamicButton_Click;
                    // Add Button to the Form. Placement of the Button

                    // will be based on the Location and Size of button

                    FlpCategorias.Controls.Add(dynamicButton);
                }
            }
            else
            {

                //se uma categoria não tiver nenhum produto = não aparecer o botão

                int qtdproduto = 0;
                if (prodDAO.Listaproduto != null)
                {

                    FlpCategorias.Controls.Clear();
                    qtdproduto = prodDAO.Listaproduto.Rows.Count;

                    for (int i = 0; i < qtdproduto; i++)
                    {
                        // Create a Button object 
                        Button dynamicButton = new Button();

                        // Set Button properties
                        int x = screenWidth - (screenWidth * 30 / 100), y = screenHeight - (screenHeight * 30 / 100);

                        if (orientation.ToString() == "Angle0")
                        {
                            dynamicButton.Width = (x / 5) - 10;
                            dynamicButton.Height = (y / 3);
                        }
                        else if (orientation.ToString() == "Angle90")
                        {
                            dynamicButton.Width = (x / 3) - 10;
                            dynamicButton.Height = (y / 5);
                        }


                        // dynamicButton.BackColor = Color.Red;
                        //dynamicButton.ForeColor = Color.Blue;
                        // dynamicButton.Location = new Point(20, 150);
                        dynamicButton.Text = prodDAO.Listaproduto.Rows[i]["nome"].ToString();
                        // dynamicButton.Name = "DynamicButton";
                        // dynamicButton.Font = new Font("Georgia", 16);
                        // Add a Button Click Event handler
                        Params.Add(dynamicButton, new Tuple<int, string>(1, dynamicButton.Text));
                        dynamicButton.Click += DynamicButton_Click;
                        // Add Button to the Form. Placement of the Button

                        // will be based on the Location and Size of button

                        FlpCategorias.Controls.Add(dynamicButton);
                    }
                    BtnVoltar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não existe produtos cadastrados para essa categoria!");
                }
            }
        }
    
        public void Excluiritem(string nome)
        {
            listaitens.Remove(nome);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FlpCategorias.Controls.Clear();
            prodDAO.Listaproduto = null;
            CarregarCategorias();
            BtnVoltar.Visible = false;
        }

        private void FlpItens_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (FlpItens.Controls.Count == 0)
            {
                BtnFinalizarpedido.Visible = false;
            }
        }
    }
}
