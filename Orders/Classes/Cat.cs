using Orders.ClassesDAO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Orders.Classes
{
    public partial class Cat : UserControl
    {
        ProdutoDAO prodDAO = new ProdutoDAO();
        Produto prod = new Produto();
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
                Height = 500;
                FlpProduto.Height = 380;
                BtnExpandir.BackgroundImage = Image.FromFile("C:\\Users\\Uzann\\Downloads\\mais.png");
                BtnExpandir.BackgroundImageLayout = ImageLayout.Stretch;
                Carregarprodutos(prodDAO.ListaProdCat(LblCategorias.Text));
                BtnNovoProd.Visible = true;
                lblProduto.Visible = true;
                TxtProduto.Visible = true;
              
                

            }
            else
            {
                FlpProduto.Controls.Clear();
                Height = 122;
                lblProduto.Visible = false;
                TxtProduto.Visible = false;
                BtnNovoProd.Visible = false;
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
               
                string caminho = lista.Rows[i]["imagem"].ToString();
                if (File.Exists(caminho))
                 {
                     prod.Pctproduto.BackgroundImage = Image.FromFile(caminho);
                     prod.Pctproduto.BackgroundImageLayout = ImageLayout.Stretch;
                  }
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

        private void BtnNovoProd_Click(object sender, EventArgs e)
        {
            
            if (LblNomeProd.Visible ==false && LblPreco.Visible ==false && txtCadProd.Visible ==false && TxtPrecoProd.Visible ==false && BtnCadProd.Visible==false && BtnImgProd.Visible == false && PctCadProd.Visible == false)
            {
                LblNomeProd.Visible = true;
                LblPreco.Visible = true;
                txtCadProd.Visible = true;
                TxtPrecoProd.Visible = true;
                BtnCadProd.Visible = true;
                BtnImgProd.Visible = true;
                PctCadProd.Visible = true;
                BtnNovoProd.Text = "Cancelar";
            }
            else
            {
                BtnNovoProd.Text = "Novo";
                LblNomeProd.Visible = false;
                LblPreco.Visible = false;
                txtCadProd.Visible = false;
                TxtPrecoProd.Visible = false;
                BtnCadProd.Visible = false;
                BtnImgProd.Visible = false;
                PctCadProd.Visible = false;

            }     
        }

        private void BtnImgProd_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog()
            {
                Title = "Selecionar Arquivo",
                InitialDirectory = @"C:\",
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                FilterIndex = 1
            };
            op.ShowDialog();
            if (File.Exists(op.FileName))
            {
                PctCadProd.BackgroundImage = Image.FromFile(op.FileName);
                PctCadProd.BackgroundImageLayout = ImageLayout.Stretch;
                prod.Imagem = op.FileName;
            }
        }

        private void BtnCadProd_Click(object sender, EventArgs e)
        {
            if (TxtPrecoProd.Text == string.Empty || PctCadProd.ImageLocation == string.Empty || txtCadProd.Text == string.Empty)
            {
                if (txtCadProd.Text == string.Empty)
                    txtCadProd.BackColor = Color.Red;
                MessageBox.Show("Favor preencher as informações");
            }
            else
            {
                try
                {
                    prod.Nome = txtCadProd.Text;
                    prod.Preco = TxtPrecoProd.Text;
                  //  prod.Id_marca = 0;
                    prod.Id_categoria =Convert.ToInt32(Tag);
                    prodDAO.Inserir(prod);
                    // FrmRefresh();
                    FlpProduto.Controls.Clear();
                    //CarregarCat(catDAO.ListarCat(string.Empty, false));
                    Carregarprodutos(prodDAO.ListaProdCat(LblCategorias.Text));
                    if (BtnExpandir.Enabled == false)
                    {
                        BtnNovoProd.Visible = false;
                    }
                    BtnExpandir.Enabled = true;
                    BtnNovoProd.Size = new Size(75, 23);
                    BtnNovoProd.Text = "Novo";
                    BtnNovoProd.Location = new Point(405, 95);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Favor verificar as informações digitadas !!!");
                }

                PctCadProd.Image = null;
                txtCadProd.Text = string.Empty;
                TxtPrecoProd.Text = string.Empty;
            }
        }
    }
}
