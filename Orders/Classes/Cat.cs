using System;
using System.Drawing;
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
            Controls.Clear();
            Dispose();
        }

        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            if (Height < 410)
            {
                Height = 410;
                ProdutoControl pc = new ProdutoControl();
                FlpProduto.Controls.Add(pc);
                BtnExpandir.Text = "Menos detalhes";
                BtnExpandir.BackgroundImage = Image.FromFile("C:\\Users\\Uzann\\Downloads\\mais.png");
                BtnExpandir.BackgroundImageLayout = ImageLayout.Stretch;
                

            }
            else
            {
               // BtnExpandir.Text = "Mais detalhes";
                Height = 122;
              
                BtnExpandir.BackgroundImage = Image.FromFile("C:\\Users\\Uzann\\Downloads\\menos.png");
                BtnExpandir.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
