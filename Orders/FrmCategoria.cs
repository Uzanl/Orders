using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrmCategoria : Form
    {
        readonly CategoriaDAO catDAO = new CategoriaDAO();
        readonly Categoria cat = new Categoria();
        readonly ProdutoDAO prodDAO = new ProdutoDAO();

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            FrmRefresh();
        }

        private void FrmRefresh()
        {
            CarregarCat(catDAO.ListarCat(string.Empty, false));
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (!panel2.Visible)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void TxtCategoria_TextChanged(object sender, EventArgs e)
        {
            FlpCat.Controls.Clear();
            if (TxtCategoria.Text != string.Empty)
            {
                CarregarCat(catDAO.ListarCat(TxtCategoria.Text, false));
            }
            else
            {
                FlpCat.Controls.Clear();
                FrmRefresh();
            }
        }

        private void BtnAdicionarImagem_Click(object sender, EventArgs e)
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
                PctCadCat.BackgroundImage = Image.FromFile(op.FileName);
                PctCadCat.BackgroundImageLayout = ImageLayout.Stretch;
                cat.Imagem = op.FileName;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadNome.Text == string.Empty || PctCadCat.ImageLocation == string.Empty)
            {
                if (txtCadNome.Text == string.Empty)
                    txtCadNome.BackColor = Color.Red;
                MessageBox.Show("Favor preencher as informações");
            }
            else
            {
                try
                {
                    cat.Nome = txtCadNome.Text;
                    catDAO.Inserir(cat);
                    FrmRefresh();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Favor verificar as informações digitadas !!!");
                }

                PctCadCat.Image = null;
                txtCadNome.Text = string.Empty;
            }
        }

        private void CarregarCat(DataTable lista)
        {
            FlpCat.Controls.Clear();
            int i = 0;
            while (FlpCat.Controls.Count < lista.Rows.Count)
            {
                Cat cat = new Cat();
                cat.LblCategorias.Text = lista.Rows[i]["nome"].ToString();
                cat.Tag = lista.Rows[i]["ID"].ToString();
                if (prodDAO.VerificaCategoria(cat.LblCategorias.Text) == true)
                {
                    cat.BtnExpandir.Enabled = true;

                }
                else
                {
                    cat.BtnNovoProd.Visible = true;
                    cat.BtnNovoProd.Text = "Adicione um produto";
                    cat.BtnNovoProd.Width = 200;
                    cat.BtnNovoProd.Location = new Point(405, 50);
                    
                }              
                string caminho = lista.Rows[i]["imagem"].ToString();
                if (File.Exists(caminho))
                {
                    cat.Pctcategoria.BackgroundImage = Image.FromFile(caminho);
                    cat.Pctcategoria.BackgroundImageLayout = ImageLayout.Stretch;
                }
                FlpCat.Controls.Add(cat);
                i++;
            }    
        }
    }
}
