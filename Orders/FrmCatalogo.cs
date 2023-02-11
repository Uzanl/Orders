using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public Dictionary<object, Tuple<int, string>> Params = new Dictionary<object, Tuple<int, string>>();
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            Conexao.criar_Conexao();
            var orientation = SystemInformation.ScreenOrientation;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            if (orientation.ToString() == "Angle0" || orientation.ToString() == "Angle90")
            {
                int x = screenWidth - (screenWidth * 25 / 100), y = screenHeight - (screenHeight * 25 / 100);
                flowLayoutPanel1.Size = new Size(x, y);
                flowLayoutPanel1.Location = new Point((screenWidth / 2) - (x / 2), (screenHeight / 2) - (y / 2));
                // btnProvisorio.Location = new Point(200, 300);
            }

            CarregarCategorias();

        }

        private void CarregarCategorias()
        {
            catDAO.ListarCategorias();

            //int qtdcategorias = cliDAO.Listacliente.Rows.Count;
            AcrescentarButtons();
        }

        private void DynamicButton_Click(object sender, EventArgs e)

        {
            

            Tuple<int, string> value;
            if (Params.TryGetValue(sender, out value))
            {
                // MessageBox.Show(value.Item1.ToString() + ": " + value.Item2);

                catDAO.Listacategoria = null;
                prodDAO.VerificaNOMEPESQ(value.Item2);
                AcrescentarButtons();
            }
            else
            {
                MessageBox.Show(sender.ToString() + " not found.");
            }


            //talvez dê para colocar os produtos na mesma tela do catalogo
            // FrmProduto p = new FrmProduto();
            //  p.Owner = this;
            // p.ShowDialog();
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
                    int x = screenWidth - (screenWidth * 25 / 100), y = screenHeight - (screenHeight * 25 / 100);

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
                    // dynamicButton.Name = "DynamicButton";
                    // dynamicButton.Font = new Font("Georgia", 16);
                    // Add a Button Click Event handler
                    Params.Add(dynamicButton, new Tuple<int, string>(1, dynamicButton.Text));
                    dynamicButton.Click += DynamicButton_Click;
                    // Add Button to the Form. Placement of the Button

                    // will be based on the Location and Size of button

                    flowLayoutPanel1.Controls.Add(dynamicButton);
                }
            }
            else
            {

                //se uma categoria não tiver nenhum produto = não aparecer o botão

                int qtdproduto = 0;
                if (prodDAO.Listaproduto != null)
                {

                    flowLayoutPanel1.Controls.Clear();
                    qtdproduto = prodDAO.Listaproduto.Rows.Count;

                    for (int i = 0; i < qtdproduto; i++)
                    {
                        // Create a Button object 
                        Button dynamicButton = new Button();

                        // Set Button properties
                        int x = screenWidth - (screenWidth * 25 / 100), y = screenHeight - (screenHeight * 25 / 100);

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
                        dynamicButton.Click += new EventHandler(DynamicButton_Click);
                        // Add Button to the Form. Placement of the Button

                        // will be based on the Location and Size of button

                        flowLayoutPanel1.Controls.Add(dynamicButton);
                    }
                    btnteste.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não existe produtos cadastrados para essa categoria!");
                }

            }

        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // flowLayoutPanel1.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void btnteste_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            prodDAO.Listaproduto = null;
            CarregarCategorias();
            btnteste.Visible = false;
        }
    }
}
