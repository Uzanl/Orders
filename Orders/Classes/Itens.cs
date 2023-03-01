using Orders.ClassesDAO;
using System;
using System.Windows.Forms;

namespace Orders.Classes
{
    public partial class Itens : UserControl
    {
        //  CategoriaDAO catDAO = new CategoriaDAO();
        Pedido ped = new Pedido();
        public Itens()
        {
            InitializeComponent();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            ped.Subtotal -= Convert.ToDouble(LblPreco.Text);
            MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
            MAIN.Excluiritem(Convert.ToInt32(Tag),LblItem.Text);
            Controls.Clear();
            Dispose();
        }
    }
}
