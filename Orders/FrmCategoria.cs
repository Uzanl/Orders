using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Orders
{
    public partial class FrmCategoria : Form
    {
        CategoriaDAO catDAO = new CategoriaDAO();
        Categoria cat = new Categoria();
        List<string> listacategorias = new List<string>();


        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCadCategoria_Load(object sender, EventArgs e)
        {
            // catDAO.Listacategoria = null;

            catDAO.ListarCategorias();

            if (catDAO.Listacategoria.Rows.Count != 0)
            {

                int qtdcategorias = catDAO.Listacategoria.Rows.Count;

                for (int i = 0; i < qtdcategorias; i++)
                {
                    if (!listacategorias.Contains(catDAO.Listacategoria.Rows[i]["nome"].ToString()))
                    {
                        Cat cat = new Cat();
                        cat.LblCategorias.Text = catDAO.Listacategoria.Rows[i]["nome"].ToString();

                        string path = catDAO.Listacategoria.Rows[i]["imagem"].ToString();

                        if (File.Exists(path))
                        {
                            cat.Pctcategoria.BackgroundImage = Image.FromFile(path);
                            cat.Pctcategoria.BackgroundImageLayout = ImageLayout.Stretch;
                        }

                        FlpCat.Controls.Add(cat);
                        listacategorias.Add(catDAO.Listacategoria.Rows[i]["nome"].ToString());

                    }
                }
            }
            else
            {
                listacategorias.Clear();
                FlpCat.Controls.Clear();
            }
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
            //pra cadastrar no banco vai precisar usar a listacategorias
            if (TxtCategoria.Text != string.Empty)
            {
                   
                    catDAO.ListarCatLike(TxtCategoria.Text);
               
                if (catDAO.Listacategoria.Rows.Count != 0)
                {
                    
                    int qtdcategorias = catDAO.Listacategoria.Rows.Count;

                    for (int i = 0; i < qtdcategorias; i++)
                    {                       
                        if (!listacategorias.Contains(catDAO.Listacategoria.Rows[i]["nome"].ToString()))
                        {
                            Cat cat = new Cat();
                            cat.LblCategorias.Text = catDAO.Listacategoria.Rows[i]["nome"].ToString();

                            string path = catDAO.Listacategoria.Rows[i]["imagem"].ToString();

                            if (File.Exists(path))
                            {
                                cat.Pctcategoria.BackgroundImage = Image.FromFile(path);
                                cat.Pctcategoria.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                            FlpCat.Controls.Add(cat);
                            listacategorias.Add(catDAO.Listacategoria.Rows[i]["nome"].ToString());
                            
                        }
                    }
                }
                else
                {
                    listacategorias.Clear();
                    FlpCat.Controls.Clear();
                }
            }
            else
            {
                //catDAO.Listacategoria.Clear();
                listacategorias.Clear();
                FlpCat.Controls.Clear();

                catDAO.ListarCategorias();

                if (catDAO.Listacategoria.Rows.Count != 0)
                {

                    int qtdcategorias = catDAO.Listacategoria.Rows.Count;

                    for (int i = 0; i < qtdcategorias; i++)
                    {
                        if (!listacategorias.Contains(catDAO.Listacategoria.Rows[i]["nome"].ToString()))
                        {
                            Cat cat = new Cat();
                            cat.LblCategorias.Text = catDAO.Listacategoria.Rows[i]["nome"].ToString();

                            string path = catDAO.Listacategoria.Rows[i]["imagem"].ToString();

                            if (File.Exists(path))
                            {
                                cat.Pctcategoria.BackgroundImage = Image.FromFile(path);
                                cat.Pctcategoria.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                            FlpCat.Controls.Add(cat);
                            listacategorias.Add(catDAO.Listacategoria.Rows[i]["nome"].ToString());

                        }
                    }
                }
                else
                {
                    listacategorias.Clear();
                    FlpCat.Controls.Clear();
                }
            }
        }
        public void Excluiritem(string nome)
        {
            listacategorias.Remove(nome);
        }

        private void BtnAdicionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Selecionar Arquivo";
            op.InitialDirectory = @"C:\";
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            op.FilterIndex = 1;
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

            if (txtCadNome.Text== string.Empty||PctCadCat.ImageLocation==string.Empty)
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
                    PctCadCat.Image = null;
                    catDAO.ListarCategorias();

                    if (catDAO.Listacategoria.Rows.Count != 0)
                    {

                        int qtdcategorias = catDAO.Listacategoria.Rows.Count;

                        for (int i = 0; i < qtdcategorias; i++)
                        {
                            if (!listacategorias.Contains(catDAO.Listacategoria.Rows[i]["nome"].ToString()))
                            {
                                Cat cat = new Cat();
                                cat.LblCategorias.Text = catDAO.Listacategoria.Rows[i]["nome"].ToString();

                                string path = catDAO.Listacategoria.Rows[i]["imagem"].ToString();

                                if (File.Exists(path))
                                {
                                    cat.Pctcategoria.BackgroundImage = Image.FromFile(path);
                                    cat.Pctcategoria.BackgroundImageLayout = ImageLayout.Stretch;
                                }

                                FlpCat.Controls.Add(cat);
                                listacategorias.Add(catDAO.Listacategoria.Rows[i]["nome"].ToString());

                            }
                        }
                    }
                    else
                    {
                        listacategorias.Clear();
                        FlpCat.Controls.Clear();
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Favor verificar as informações digitadas !!!");
                }
            }

          
        }
    }
}
