using Google.Protobuf.WellKnownTypes;
using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrmCatalogo : Form
    {
        readonly CategoriaDAO catDAO = new CategoriaDAO();
        readonly ProdutoDAO prodDAO = new ProdutoDAO();
        readonly List<Itenspedido> listaitens = new List<Itenspedido>();
        readonly Pedido ped = new Pedido();
        readonly Produtospedido prodped = new Produtospedido();
        readonly ProdutospedidoDAO prodpedDAO = new ProdutospedidoDAO();
        readonly PedidoDAO pedDao = new PedidoDAO();

        public Dictionary<object, Tuple<int, string>> Params = new Dictionary<object, Tuple<int, string>>();
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            Conexao.Criar_Conexao();
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {

            AcrescentarButtons(catDAO.ListarCat(string.Empty, false));

            
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {

            if (Params.TryGetValue(sender, out Tuple<int, string> value))
            {

                //esse código é passível de melhorias

                if (prodDAO.ListaProdCat(value.Item2).Rows.Count > 0)
                {
                    BtnVoltar.Visible = true;
                    AcrescentarButtons(prodDAO.ListaProdCat(value.Item2));
                }
                else
                {
                    if (!listaitens.Contains(new Itenspedido(Convert.ToInt32(value.Item1), value.Item2)) && catDAO.ListarCat(value.Item2, true).Rows.Count == 0)
                    {
                        Itens item = new Itens();
                        item.LblItem.Text = value.Item2.ToString();
                        item.Lblid.Text = value.Item1.ToString();
                        FlpItens.Controls.Add(item);
                        BtnFinalizarpedido.Visible = true;

                        listaitens.Add(new Itenspedido(Convert.ToInt32(value.Item1), value.Item2));
                    }
                    else
                    {
                        MessageBox.Show("Não existe nenhum produto cadastrado nessa categoria!");
                    }
                }
            }
            else
            {
                MessageBox.Show(sender.ToString() + " not found.");
            }
        }

        public void AcrescentarItens(int id, string nome)
        {
            if (!listaitens.Contains(new Itenspedido(Convert.ToInt32(id),nome)))
            {
                Itens item = new Itens();
                item.LblItem.Text = nome.ToString();
                // item.Lblid.Text = value.Item1.ToString();
                item.Tag = id;
                FlpItens.Controls.Add(item);
                BtnFinalizarpedido.Visible = true;
                listaitens.Add(new Itenspedido(Convert.ToInt32(id),nome));
            }
        }


        public void Excluiritem(int id, string nome)
        {
            listaitens.Remove(new Itenspedido(id, nome));
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FlpCategorias.Controls.Clear();
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

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria i = new FrmCategoria();
            i.ShowDialog();
        }

        public void AcrescentarButtons(DataTable lista)
        {

            var orientation = SystemInformation.ScreenOrientation;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

         
            FlpCategorias.Controls.Clear();
            int i = 0;
            while (FlpCategorias.Controls.Count < lista.Rows.Count)
            {
                Button dynamicButton = new Button();
                Catalogo catal = new Catalogo();
                int x = screenWidth - (screenWidth * 30 / 100), y = screenHeight - (screenHeight * 30 / 100);

                if (orientation.ToString() == "Angle0")
                {
                    dynamicButton.Width = (x / 5) - 5;
                    dynamicButton.Height = (y / 3);
                }
                else if (orientation.ToString() == "Angle90")
                {
                    dynamicButton.Width = (x / 3) - 10;
                    dynamicButton.Height = (y / 5);
                }

                dynamicButton.Text = lista.Rows[i]["nome"].ToString();

              //  catal.Btncategoria.Text = lista.Rows[i]["nome"].ToString();
                //try catch provisóirio
                try
                {
                    string path = lista.Rows[i]["imagem"].ToString();

                    if (File.Exists(path))
                    {
                        dynamicButton.BackgroundImage = Image.FromFile(path);
                        dynamicButton.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                catch
                {

                }
              
                dynamicButton.Font = new Font("Arial", 12);
                dynamicButton.TextAlign = ContentAlignment.TopCenter;
                Params.Add(dynamicButton, new Tuple<int, string>(Convert.ToInt32(lista.Rows[i]["ID"].ToString()), dynamicButton.Text));
                dynamicButton.Click += DynamicButton_Click;
                FlpCategorias.Controls.Add(dynamicButton);
             //   FlpCategorias.Controls.Add(catal);

                i++;
            }


           // testando nova forma de aparecer as categorias
           FlpCategorias.Controls.Clear();
           int j = 0;
           while (FlpCategorias.Controls.Count < lista.Rows.Count)
           {          
               Catalogo catal = new Catalogo();            
                catal.Btncategoria.Text = lista.Rows[j]["nome"].ToString();
               catal.Tag = Convert.ToInt32(lista.Rows[j]["ID"].ToString());
               FlpCategorias.Controls.Add(catal);
               j++;
           }


        }

        public void AcrescentarProdutos(DataTable lista)
        {
            FlpCategorias.Controls.Clear();
            int i = 0;
            while (FlpCategorias.Controls.Count < lista.Rows.Count)
            {
                ProdCatalogo pcatal = new ProdCatalogo();
                pcatal.BtnProduto.Text = lista.Rows[i]["nome"].ToString();
                pcatal.Tag = Convert.ToInt32(lista.Rows[i]["ID"].ToString());
                FlpCategorias.Controls.Add(pcatal);
                i++;
            }
            BtnVoltar.Visible = true;
        }

        private void BtnFinalizarpedido_Click(object sender, EventArgs e)
        {
            if (FlpItens.Controls.Count > 0)
            {
                DateTime data_hora = DateTime.Now;
                ped.Id_cliente = 1;
                ped.Hora = Convert.ToDateTime(data_hora.ToLongTimeString());
                ped.Data_pedido = data_hora;
                pedDao.Inserir(ped);
                pedDao.Ultimopedido();

                string teste = " produto \r\n";
                foreach (Itenspedido aItenspedido in listaitens)
                {
                    teste += aItenspedido.Nome + "\r\n";

                    if (listaitens.IndexOf(aItenspedido) == listaitens.Count - 1)
                    {
                        DialogResult op;

                        op = MessageBox.Show("Você tem certeza dessas informações?\r\n" + teste,
                            "Salvando!", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (op == DialogResult.Yes)
                        {

                            try
                            {
                                Pedido();
                                MessageBox.Show("Pedido confirmado com sucesso!!!");
                                FlpItens.Controls.Clear();
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Favor verificar as informações digitadas !!!");
                            }
                        }
                    }
                }
            }
        }

        private void Pedido()
        {
            string teste = " produto \r\n";
            foreach (Itenspedido aItenspedido in listaitens)
            {
                prodped.Id_pedido = pedDao.Ped.Id_pedido;
                prodped.Id_produto = aItenspedido.Id_produto;
                teste += aItenspedido.Nome + "\r\n";
                prodpedDAO.Inserir(prodped);
            }
        }
    }
}
