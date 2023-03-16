using Orders.ClassesDAO;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Orders.Classes
{
    public partial class Itens : UserControl
    {
        //  CategoriaDAO catDAO = new CategoriaDAO();
        string iteminicial;
        Pedido ped = new Pedido();

        //double totalqtd;

        public double Price { get; set; }
        public Itens()
        {
            InitializeComponent();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            int quantidade = MAIN.Quantidade(Convert.ToInt32(Tag));
            // ped.Subtotal -= Convert.ToDouble(LblPreco.Text) * quantidade;
            ped.Subtotal -= Price * quantidade;
            MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
            MAIN.Excluiritem(Convert.ToInt32(Tag), true);
            Controls.Clear();
            Dispose();
        }

        private void Btnmais_Click(object sender, EventArgs e)
        {
           // btnMenos.Enabled = true;
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            MAIN.AcrescentarItens(Convert.ToInt32(Tag), LblItem.Text, /*LblPreco.Text*/ Price.ToString(), true);
            double x = ped.Subtotal;
            //double y = Convert.ToDouble(LblPreco.Text);
            double y = Price;
            double sum = x + y;
            MAIN.LblSubtotal.Text = $"Subtotal:{sum:C2}";
            ped.Subtotal = sum;
            int quantidade = MAIN.Quantidade(Convert.ToInt32(Tag));

           
            LblItem.Text = $"{quantidade}x {iteminicial}";

        }

        private void Itens_Load(object sender, EventArgs e)
        {
            iteminicial = LblItem.Text;

            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            if (MAIN.LblSubtotal.Text == string.Empty)
            {
                //ped.Subtotal = Convert.ToDouble(LblPreco.Text);
                ped.Subtotal = Price;
            }
            else
            {
                double x = ped.Subtotal;
                //double y = Convert.ToDouble(LblPreco.Text);
                double y = Price;
                double sum = x + y;
                ped.Subtotal = sum;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            if (MAIN.Quantidade(Convert.ToInt32(Tag)) > 1)
            {

                //ped.Subtotal -= Convert.ToDouble(LblPreco.Text);
                ped.Subtotal -= Price;
                MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
                MAIN.Excluiritem(Convert.ToInt32(Tag), false);
                MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
                int quantidade = MAIN.Quantidade(Convert.ToInt32(Tag));
                LblItem.Text = $"{quantidade}x {iteminicial}";
            }
        }
    }
}
