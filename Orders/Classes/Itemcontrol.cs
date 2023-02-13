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
        //Itemcontrol lista = new Itemcontrol(Listaitens);

        //  Listaitens lista = new Listaitens();
        public Itemcontrol()
        {
            InitializeComponent();

           
        }
       // FrmCatalogo frm1 = new FrmCatalogo();
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = this.ParentForm as FrmCatalogo;          
            MAIN.Excluiritem(label1.Text);          
            this.Controls.Clear();
            this.Dispose();


        }

     
    }
}
