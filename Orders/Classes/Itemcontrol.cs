using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders.Classes
{
    public partial class Itemcontrol : UserControl
    {
        public Itemcontrol()
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
