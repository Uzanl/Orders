using Orders.ClassesDAO;
using System;
using System.Data;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace Orders.Classes
{
    public partial class PedidoControl : UserControl
    {
        ProdutospedidoDAO ppDAO = new ProdutospedidoDAO();
        PedidoDAO pedDAO = new PedidoDAO();
        public PedidoControl()
        {
            InitializeComponent();
        }

        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            if (Height < 350)
            {
                CarregarProd(ppDAO.ListaProdPed(Convert.ToInt32(Tag)));
                Height = 600;
            }
            else
            {
                FlpProdutos.Controls.Clear();
                Height = 122;
            }
        }

        public void CarregarProd(DataTable lista)
        {
            FlpProdutos.Controls.Clear();
            foreach (DataRow row in lista.Rows)
            {
                ProdutoControl prod = CriarProdutoAPartirDeDadosDaLinha(row);
                FlpProdutos.Controls.Add(prod);
            }
        }

        private ProdutoControl CriarProdutoAPartirDeDadosDaLinha(DataRow row)
        {
            ProdutoControl prod = new ProdutoControl();
            prod.LblProduto.Text = row["produto"].ToString();
            int id;
            if (int.TryParse(row["ID"].ToString(), out id))
            {
                prod.Tag = id;
            }
            string caminho = row["imagem"].ToString();
            if (File.Exists(caminho))
            {
                using (var image = Image.FromFile(caminho))
                {
                    prod.Pctproduto.BackgroundImage = new Bitmap(image);
                    prod.Pctproduto.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            return prod;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime horainicio = Convert.ToDateTime(Lblhora.Text);
            DateTime horafinal = DateTime.Now;
            TimeSpan span = horafinal.Subtract(horainicio);
            Lbltimer.Text = span.ToString(@"hh\:mm\:ss");
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            Pedido ped = new Pedido();
            ped.Status = "Fechado";
            ped.Id_pedido = Convert.ToInt32(Tag);
            pedDAO.UpdateStatus(ped);
            Dispose();
            

        }
    }
}
