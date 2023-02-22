using Orders.ClassesDAO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Orders.Classes
{
    public partial class Cat : UserControl
    {
        ProdutoDAO prodDAO = new ProdutoDAO();
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

                //verificar se existe algum produto na categoria

                Height = 500;
                FlpProduto.Height = 380;

                
                
                    
                    Carregarprodutos(prodDAO.ListaProdCat(LblCategorias.Text));
              
                
                lblProduto.Visible = true;
                TxtProduto.Visible = true;
                BtnExpandir.BackgroundImage = Image.FromFile("C:\\Users\\Uzann\\Downloads\\mais.png");
                BtnExpandir.BackgroundImageLayout = ImageLayout.Stretch;


            }
            else
            {
                FlpProduto.Controls.Clear();
                Height = 122;
                lblProduto.Visible = false;
                TxtProduto.Visible = false;
                BtnExpandir.BackgroundImage = Image.FromFile("C:\\Users\\Uzann\\Downloads\\menos.png");
                BtnExpandir.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void Carregarprodutos(DataTable lista)
        {
            int i = 0;
            while (FlpProduto.Controls.Count < lista.Rows.Count)
            {
                ProdutoControl prod = new ProdutoControl();
                prod.LblCategorias.Text = lista.Rows[i]["nome"].ToString();
                //string caminho = lista.Rows[i]["imagem"].ToString();
                //if (File.Exists(caminho))
                // {
                //     prod.Pctproduto.BackgroundImage = Image.FromFile(caminho);
                //     prod.Pctproduto.BackgroundImageLayout = ImageLayout.Stretch;
                //  }
                FlpProduto.Controls.Add(prod);
                i++;
            }
        }

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {
            FlpProduto.Controls.Clear();
            if (lblProduto.Text != string.Empty)
            {
                Carregarprodutos(prodDAO.ListaProdCatLike(LblCategorias.Text, TxtProduto.Text));

                //prodDAO.ListaProdCatLike(LblCategorias.Text,TxtProduto.Text);

            }
            else
            {
                FlpProduto.Controls.Clear();
                Carregarprodutos(prodDAO.ListaProdCat(LblCategorias.Text));
            }
        }
    }
}
