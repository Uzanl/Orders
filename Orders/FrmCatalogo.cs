using Google.Protobuf.WellKnownTypes;
using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Documents;
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
     //   ProdCatalogo pca = new ProdCatalogo();

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
            AcrescentarCategorias(catDAO.ListarCat(string.Empty, false));
        }

        public void AcrescentarItens(int id, string nome,string preco, bool adicao)
        {
            if (!listaitens.Exists(x => x.Id_produto == id) && adicao == false)
            {
                Itens item = new Itens();
                item.LblItem.Text = nome;
                item.LblPreco.Text = preco; 
                item.Tag = id;
                FlpItens.Controls.Add(item);
                BtnFinalizarpedido.Visible = true;
                listaitens.Add(new Itenspedido(Convert.ToInt32(id),nome));

            }
            else if (adicao == true)
            {
                listaitens.Add(new Itenspedido(Convert.ToInt32(id), nome));
            }


            // Itens item = new Itens();

            // item.LblPreco.Text = preco;
            // item.Tag = id;
            //listaitens.Add(new Itenspedido(Convert.ToInt32(id), nome));
            // int quantidade = Quantidade(Convert.ToInt32(id));
            // item.LblItem.Text =$"{quantidade}x {nome}";
            // FlpItens.Controls.Add(item);
            // BtnFinalizarpedido.Visible = true;


        }

        public void Excluiritem(int id, string nome,bool removetodos)
        {
            //listaitens.Remove(new Itenspedido(id,nome));

            var itemToRemove = listaitens.FirstOrDefault(u => u.Id_produto == id);

            // if found, remove it
            if (itemToRemove != null && removetodos == false)
            {
                listaitens.Remove(itemToRemove);
            }
            else
            {
                listaitens.RemoveAll(u => u.Id_produto == id);
               // ProdCatalogo pc = new ProdCatalogo();
               
                //  LblSubtotal.Text = string.Empty;

            }

           
              
            
          
                
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            ProdCatalogo pc = new ProdCatalogo();
            pc.Dispose();
            FlpCategorias.Controls.Clear();
            CarregarCategorias();
            BtnVoltar.Visible = false;
        }

        private void FlpItens_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (FlpItens.Controls.Count == 0)
            {
               // BtnFinalizarpedido.Visible = false;
            }
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria i = new FrmCategoria();
            i.ShowDialog();
        }

        public void AcrescentarCategorias(DataTable lista)
        {
            FlpCategorias.Controls.Clear();
            int j = 0;
            while (FlpCategorias.Controls.Count < lista.Rows.Count)
            {
                Catalogo catal = new Catalogo();
                catal.Btncategoria.Text = lista.Rows[j]["nome"].ToString();
                catal.Tag = Convert.ToInt32(lista.Rows[j]["ID"].ToString());
                string caminho = lista.Rows[j]["imagem"].ToString();
                if (File.Exists(caminho))
                {
                    catal.Btncategoria.BackgroundImage = Image.FromFile(caminho);
                    catal.Btncategoria.BackgroundImageLayout = ImageLayout.Stretch;
                }
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
                pcatal.BtnProduto.Text =$"{lista.Rows[i]["nome"]} \r\n preço: {Convert.ToDouble(lista.Rows[i]["preco"]):C2}" ;
                pcatal.Tag = Convert.ToInt32(lista.Rows[i]["ID"].ToString());
                pcatal.LblPreco.Text = lista.Rows[i]["preco"].ToString();
                string caminho = lista.Rows[i]["imagem"].ToString();
                if (File.Exists(caminho))
                {
                    pcatal.BtnProduto.BackgroundImage = Image.FromFile(caminho);
                    pcatal.BtnProduto.BackgroundImageLayout = ImageLayout.Stretch;
                }
                FlpCategorias.Controls.Add(pcatal);
                i++;
            }
            BtnVoltar.Visible = true;
        }

        private void BtnFinalizarpedido_Click(object sender, EventArgs e)
        {
            if (FlpItens.Controls.Count > 0)
            {
                string teste = " produto \r\n";
                foreach (Itenspedido aItenspedido in listaitens)
                {
                     teste += aItenspedido.Nome + "\r\n";
                }


                DialogResult op;
                
                op = MessageBox.Show("Você tem certeza dessas informações?\r\n" + teste,
                    "Salvando!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (op == DialogResult.Yes)
                {

                    try
                    {
                        foreach (Itenspedido aItenspedido in listaitens)
                        {
                            
                            if (listaitens.IndexOf(aItenspedido) == listaitens.Count - 1)
                            {
                                DateTime data_hora = DateTime.Now;
                                ped.Id_cliente = 1;
                                ped.Hora = Convert.ToDateTime(data_hora.ToLongTimeString());
                                ped.Data_pedido = data_hora;
                                ped.Status = "Em aberto";
                                pedDao.Inserir(ped);
                                pedDao.Ultimopedido();
                                Pedido();
                                LblSubtotal.Text = string.Empty;
                                
                            }                           
                        }
                        FlpItens.Controls.Clear();
                        MessageBox.Show("Pedido confirmado com sucesso!!!");
                        listaitens.Clear();


                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Favor verificar as informações digitadas !!!");
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

        public int Quantidade(int id)
        {
            int quantidade  = listaitens.Where( Itenspedido=> Itenspedido.Id_produto == id).Count(); ;
            return quantidade;
        }

        private void PedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido i = new FrmPedido();
            i.ShowDialog();
        }

        private void FlpItens_ControlAdded(object sender, ControlEventArgs e)
        {
            //ProdCatalogo pc = new ProdCatalogo();
      //      ped.Subtotal = Convert.ToDouble(pca.LblPreco.Text);
            LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
        }
    }
}
