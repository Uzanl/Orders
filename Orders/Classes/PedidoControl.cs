using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders.Classes
{
    public partial class PedidoControl : UserControl
    {
        ProdutospedidoDAO ppDAO = new ProdutospedidoDAO();
        public PedidoControl()
        {
            InitializeComponent();
        }

        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            CarregarProd(ppDAO.ListaProdPed(Convert.ToInt32(Tag)));
        }

        private void CarregarProd(DataTable lista)
        {
            FlpProdutos.Controls.Clear();
            int i = 0;
            while (FlpProdutos.Controls.Count < lista.Rows.Count)
            {

                ProdutoControl prod = new ProdutoControl();
                prod.LblCategorias.Text = lista.Rows[i]["produto"].ToString();
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
    }
}
