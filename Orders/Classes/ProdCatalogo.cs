using Orders.ClassesDAO;
using System;
using System.Windows.Forms;


namespace Orders.Classes
{
    public partial class ProdCatalogo : UserControl
    {
        Pedido ped = new Pedido();

        public static double price;
       // int i = 0;
        public static double Price { get => price; set => price = value; }

        public ProdCatalogo()
        {
            InitializeComponent();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
           // BtnProduto.Tag = Tag;
           // BtnProduto.Enabled = false;
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            //subtotal nem era para ser feito aqui. Deve ser feito ao adicionar ao painel. controladded
            MAIN.AcrescentarItens(Convert.ToInt32(Tag), BtnProduto.Text, LblPreco.Text, false);
        
            

         
        }

      
    }
}
