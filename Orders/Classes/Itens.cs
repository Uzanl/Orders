using System;
using System.Windows.Forms;

namespace Orders.Classes
{
    public partial class Itens : UserControl
    {
        //  CategoriaDAO catDAO = new CategoriaDAO();
      
        public Itens()
        {
            InitializeComponent();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            MAIN.Excluiritem(Convert.ToInt32(Lblid.Text));
            Controls.Clear();
            Dispose();
        }
    }
}
