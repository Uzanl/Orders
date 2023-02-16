using System;
using System.Windows.Forms;

namespace Orders.Classes
{
    public partial class Itens : UserControl
    {
        public Itens()
        {
            InitializeComponent();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = this.ParentForm as FrmCatalogo;
            MAIN.Excluiritem(LblItem.Text);
            this.Controls.Clear();
            this.Dispose();
        }
    }
}
