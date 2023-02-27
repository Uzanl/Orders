using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrmPedido : Form
    {
        PedidoDAO pedDAO = new PedidoDAO();
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregarCat(pedDAO.ListaPedData(DateTime.Now));
        }

        private void CarregarCat(DataTable lista)
        {
            FlpPedidos.Controls.Clear();
            int i = 0;
            while (FlpPedidos.Controls.Count < lista.Rows.Count)
            {
                PedidoControl pc = new PedidoControl();
                
                pc.Tag = lista.Rows[i]["ID"].ToString();
                pc.Lblid.Text = lista.Rows[i]["ID"].ToString();
                pc.lblNome.Text = lista.Rows[i]["CLIENTE"].ToString();
                pc.Lblhora.Text = lista.Rows[i]["HORA"].ToString();
                FlpPedidos.Controls.Add(pc);
                i++;
            }
        }
    }
}
