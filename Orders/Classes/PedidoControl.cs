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

        private void CarregarProd(DataTable lista)
        {
            FlpProdutos.Controls.Clear();
            int i = 0;
            while (FlpProdutos.Controls.Count < lista.Rows.Count)
            {

                ProdutoControl prod = new ProdutoControl();
                prod.LblProduto.Text = lista.Rows[i]["produto"].ToString();
                prod.Tag = lista.Rows[i]["ID"].ToString();
                string caminho = lista.Rows[i]["imagem"].ToString();
                if (File.Exists(caminho))
                {
                    prod.Pctproduto.BackgroundImage = Image.FromFile(caminho);
                    prod.Pctproduto.BackgroundImageLayout = ImageLayout.Stretch;
                }

                FlpProdutos.Controls.Add(prod);
                i++;
            }
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
