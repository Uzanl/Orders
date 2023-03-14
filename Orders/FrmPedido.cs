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
            CarregarPed(pedDAO.ListaPedData(DateTime.Now));
        }

        private void CarregarPed(DataTable lista)
        {
            FlpPedidos.Controls.Clear();
            foreach (DataRow row in lista.Rows)
            {
                PedidoControl pc = new PedidoControl() { Tag = row["ID"].ToString()};              
                pc.Lblid.Text = row["ID"].ToString();
                pc.lblNome.Text = row["CLIENTE"].ToString();
                pc.Lblhora.Text = row["HORA"].ToString();
                pc.LblStatus.Text = row["STATUS"].ToString();
                FlpPedidos.Controls.Add(pc);
            }
        }
    }
}
