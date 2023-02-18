using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
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
        readonly List<string> listacategorias = new List<string>();
        // criar um void que retorna essa lista e tem como parametro de entrado a outra lista

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
            CarregarCat(catDAO.ListarCategorias());
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
            listacategorias.Clear();
            FlpCat.Controls.Clear();
            if (TxtCategoria.Text != string.Empty)
            {              
                CarregarCat(catDAO.ListarCatLike(TxtCategoria.Text));
            }
            else
            {
                listacategorias.Clear();
                FlpCat.Controls.Clear();
                FrmRefresh();
            }
        }
        public void Excluiritem(string nome)
        {
            listacategorias.Remove(nome);
        }

        private void BtnAdicionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog() { 
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
            //colocar try catch aqui ou lista.rows.count!= 0           
                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    if (!listacategorias.Contains(lista.Rows[i]["nome"].ToString()))
                    {
                        Cat cat = new Cat();
                        cat.LblCategorias.Text = lista.Rows[i]["nome"].ToString();

                        string path = lista.Rows[i]["imagem"].ToString();

                        if (File.Exists(path))
                        {
                            cat.Pctcategoria.BackgroundImage = Image.FromFile(path);
                            cat.Pctcategoria.BackgroundImageLayout = ImageLayout.Stretch;
                        }

                        FlpCat.Controls.Add(cat);
                        listacategorias.Add(lista.Rows[i]["nome"].ToString());
                    }
                }           
        }
    }
}
