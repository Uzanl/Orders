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
    public partial class Cat : UserControl
    {
        public Cat()
        {
            InitializeComponent();
        }

        private void Catcontrol_Load(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FrmCategoria MAIN = this.ParentForm as FrmCategoria;
            MAIN.Excluiritem(LblCategorias.Text);
            this.Controls.Clear();
            this.Dispose();
        }
    }
}
