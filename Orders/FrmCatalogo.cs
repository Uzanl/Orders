using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrmCatalogo : Form
    {
        readonly CategoriaDAO catDAO = new CategoriaDAO();
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

            if (UsuarioDAO.tipo == "Garçom")
            {
                CategoriasToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;

            }else if (UsuarioDAO.tipo == "Mesa")
            {
                menuStrip1.Visible = false;
            }
            LblNome.Text = $"Olá, {UsuarioDAO.Login} !";
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            AcrescentarCategorias(catDAO.ListarCat(string.Empty, false));
        }

        // public void AcrescentarItens(int id, string nome, string preco, bool adicao)
        // {
        //    if (adicao)
        //    {
        //        listaitens.Add(new Itenspedido(Convert.ToInt32(id), nome));
        //    }
        //     else if (!listaitens.Exists(x => x.Id_produto == id))
        //     {
        //        Itens item = new Itens();
        //         item.LblItem.Text = nome;
        //          item.Price = Convert.ToDouble(preco);
        //         item.Tag = id;
        //         FlpItens.Controls.Add(item);
        //         BtnFinalizarpedido.Visible = true;
        //        listaitens.Add(new Itenspedido(Convert.ToInt32(id), nome));
        //  }

        public void AcrescentarItens(int id, string nome, string preco, bool adicao)
        {
            if (adicao)
            {

                // Itens.Quantidade++;

                Itenspedido item_alterar = listaitens.FirstOrDefault(item => item.Id_produto == id);

                if (item_alterar != null)
                {
                    // Altere a quantidade do objeto encontrado
                    item_alterar.Quantidade++;
                }

                // listaitens.Add(new Itenspedido(Convert.ToInt32(id), nome));
            }
            else if (!listaitens.Exists(x => x.Id_produto == id))
            {
                //Itens.Quantidade = 1;
                Itens item = new Itens();
                item.LblItem.Text = nome;
                item.Price = Convert.ToDouble(preco);
                item.Tag = id;
                FlpItens.Controls.Add(item);
                BtnFinalizarpedido.Visible = true;
                listaitens.Add(new Itenspedido(Convert.ToInt32(id), nome, 1));
            }


        }
        public void DecrescerQtd(int id)
        {
            Itenspedido item_alterar = listaitens.FirstOrDefault(item => item.Id_produto == id);

            if (item_alterar != null)
            {
                // Altere a quantidade do objeto encontrado
                item_alterar.Quantidade--;
            }
        }



        public void Excluiritem(int id, bool removetodos)
        {

            var itemToRemove = listaitens.FirstOrDefault(u => u.Id_produto == id);

            if (itemToRemove != null && removetodos == false)
            {
                listaitens.Remove(itemToRemove);
            }
            else
            {
                listaitens.RemoveAll(u => u.Id_produto == id);
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
            FlpCategorias.Controls.Clear();
            foreach (DataRow row in lista.Rows)
            {
                Catalogo catal = CriarCatalogoAPartirDeDadosDaLinha(row);
                FlpCategorias.Controls.Add(catal);
            }
        }

        private Catalogo CriarCatalogoAPartirDeDadosDaLinha(DataRow row)
        {
            Catalogo catal = new Catalogo();
            catal.Btncategoria.Text = row["nome"].ToString();
            int id;
            if (int.TryParse(row["ID"].ToString(), out id))
            {
                catal.Tag = id;
            }
            string caminho = row["imagem"].ToString();
            if (File.Exists(caminho))
            {
                using (var image = Image.FromFile(caminho))
                {
                    catal.Btncategoria.BackgroundImage = new Bitmap(image);
                    catal.Btncategoria.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            return catal;
        }

        public void AcrescentarProdutos(DataTable lista)
        {
            FlpCategorias.Controls.Clear();
            foreach (DataRow row in lista.Rows)
            {
                ProdCatalogo pcatal = CriarProdCatalogoAPartirDeDadosDaLinha(row);
                FlpCategorias.Controls.Add(pcatal);
            }
            BtnVoltar.Visible = true;
        }

        private ProdCatalogo CriarProdCatalogoAPartirDeDadosDaLinha(DataRow row)
        {
            ProdCatalogo pcatal = new ProdCatalogo();
            pcatal.BtnProduto.Text = $"{row["nome"]} \r\n preço: {Convert.ToDouble(row["preco"]):C2}";
            int id;
            if (int.TryParse(row["ID"].ToString(), out id))
            {
                pcatal.Tag = id;
            }
            pcatal.LblPreco.Text = row["preco"].ToString();
            string caminho = row["imagem"].ToString();
            if (File.Exists(caminho))
            {
                using (var image = Image.FromFile(caminho))
                {
                    pcatal.BtnProduto.BackgroundImage = new Bitmap(image);
                    pcatal.BtnProduto.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            return pcatal;
        }

        private void BtnFinalizarpedido_Click(object sender, EventArgs e)
        {
            if (FlpItens.Controls.Count > 0)
            {
                string listaItens = "";
                double subtotal = 0;
                foreach (Itens item in FlpItens.Controls)
                {
                    double preco = item.Price;
                    int qtd = Quantidade(Convert.ToInt32(item.Tag));
                    subtotal += preco * qtd;
                    listaItens += $"{item.LblItem.Text}\r\n{preco * qtd:C2}\r\n";
                }

                var dialogResult = MessageBox.Show($"Você tem certeza dessas informações?\r\n{listaItens}{LblSubtotal.Text}",
                    "Salvando!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        DateTime data_hora = DateTime.Now;
                        ped.Id_cliente = UsuarioDAO.Id; // arrumar isso depois
                        ped.Hora = Convert.ToDateTime(data_hora.ToLongTimeString());
                        ped.Data_pedido = data_hora;
                        ped.Status = "Em aberto";
                        pedDao.Inserir(ped); // ERRO ACONTECE, POIS ESTOU USANDO ID_USU AO INVÉS DO ID_CLIENTE.
                        pedDao.Ultimopedido();
                        Pedido();
                        LblSubtotal.Text = string.Empty;

                        LimparListaItens();
                        MessageBox.Show("Pedido confirmado com sucesso!!!");

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Favor verificar as informações digitadas !!!");
                    }
                }
            }
        }

        private void LimparListaItens()
        {
            FlpItens.Controls.Clear();
            BtnFinalizarpedido.Visible = false;
            listaitens.Clear();
        }


        private void Pedido()
        {

            string teste = " produto \r\n";
            foreach (Itenspedido aItenspedido in listaitens)
            {

                prodped.Id_pedido = pedDao.Ped.Id_pedido;
                prodped.Id_produto = aItenspedido.Id_produto;
                prodped.Quantidade = aItenspedido.Quantidade;
                teste += aItenspedido.Nome + "\r\n";
                prodpedDAO.Inserir(prodped);
            }

        }

        public int Quantidade(int id)
        {
            Itenspedido item_pesquisa = listaitens.FirstOrDefault(item => item.Id_produto == id);
            int quantidade;
            quantidade = item_pesquisa.Quantidade;
            return quantidade;
        }



        private void PedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido i = new FrmPedido();
            i.ShowDialog();
        }

        private void FlpItens_ControlAdded(object sender, ControlEventArgs e)
        {
            LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUsu u = new FrmCadUsu();
            u.ShowDialog();
        }
    }
}
