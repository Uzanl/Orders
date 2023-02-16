using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;
using Orders.Classes;
using Orders.ClassesDAO;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrmCategoria : Form
    {
        CategoriaDAO catDAO = new CategoriaDAO();
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
    }
}
