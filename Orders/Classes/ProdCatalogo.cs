using Orders.ClassesDAO;
using System;
using System.Windows.Forms;


namespace Orders.Classes
{
    public partial class ProdCatalogo : UserControl
    {
        Pedido ped = new Pedido();

        public static double price;
        int i = 0;
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
          

            while (i < 1)
            {
                MAIN.AcrescentarItens(Convert.ToInt32(Tag), BtnProduto.Text, LblPreco.Text, false);
                  if (MAIN.LblSubtotal.Text == string.Empty)
                   {

                       ped.Subtotal = Convert.ToDouble(LblPreco.Text);
                      MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
                   }
                  else
                  {
                    double x = ped.Subtotal;
                    double y = Convert.ToDouble(LblPreco.Text);
                    double sum = x + y;
                     MAIN.LblSubtotal.Text = $"Subtotal:{sum:C2}";
                 ped.Subtotal = sum;    
                }
                i++;
            }

            
            

         
        }
    }
}
