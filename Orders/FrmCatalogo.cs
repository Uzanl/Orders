using Google.Protobuf.WellKnownTypes;
using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Data;
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
            AcrescentarCategorias(catDAO.ListarCat(string.Empty, false));
        }

        public void AcrescentarItens(int id, string nome)
        {
            if (!listaitens.Contains(new Itenspedido(Convert.ToInt32(id),nome)))
            {
                Itens item = new Itens();
                item.LblItem.Text = nome.ToString();
                item.Tag = id;
                FlpItens.Controls.Add(item);
                BtnFinalizarpedido.Visible = true;
                listaitens.Add(new Itenspedido(Convert.ToInt32(id),nome));
                
            }
        }

        public void Excluiritem(int id, string nome)
        {
            listaitens.Remove(new Itenspedido(id,nome));
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
                BtnFinalizarpedido.Visible = false;
            }
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria i = new FrmCategoria();
            i.ShowDialog();
        }

        public void AcrescentarCategorias(DataTable lista)
        {
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
                pcatal.BtnProduto.Text =$"{lista.Rows[i]["nome"]} \r\n preço: {Convert.ToDouble(lista.Rows[i]["preco"]).ToString("C2")}" ;
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
                                MessageBox.Show("Pedido confirmado com sucesso!!!");
                                FlpItens.Controls.Clear();
                            }
                        }

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

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido i = new FrmPedido();
            i.ShowDialog();
        }
    }
}
