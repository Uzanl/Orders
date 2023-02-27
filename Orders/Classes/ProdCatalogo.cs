using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class ProdCatalogo : UserControl
    {
        public ProdCatalogo()
        {
            InitializeComponent();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            MAIN.AcrescentarItens(Convert.ToInt32(Tag), BtnProduto.Text);
        }
    }
}
