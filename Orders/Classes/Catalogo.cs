using Google.Protobuf.WellKnownTypes;
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

namespace Orders.Classes
{
    public partial class Catalogo : UserControl
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Btncategoria_Click(object sender, EventArgs e)
        {

            ProdutoDAO prodDAO = new ProdutoDAO();
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            prodDAO.VerificaCategoriaId(Convert.ToInt32(Tag));

            if (prodDAO.VerificaCategoriaId(Convert.ToInt32(Tag))==true)
            {
                MAIN.AcrescentarProdutos(prodDAO.ListaProdCatId(Convert.ToInt32(Tag)));
                Controls.Clear();
                Dispose();
            }
            else
            {
                MessageBox.Show("Não existem produtos cadastrados nessa categoria!");
            }
          
          
        }
    }
}
