﻿using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrmCatalogo : Form
    {
        readonly CategoriaDAO catDAO = new CategoriaDAO();
        readonly ProdutoDAO prodDAO = new ProdutoDAO();
        readonly List<string> listaitens = new List<string>();

        public Dictionary<object, Tuple<int, string>> Params = new Dictionary<object, Tuple<int, string>>();
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            Conexao.Criar_Conexao();
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {

            AcrescentarButtons(catDAO.ListarCat(string.Empty,false));
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {

            if (Params.TryGetValue(sender, out Tuple<int, string> value))
            {
                //chama novamente o void de acrescentar os botões caso clique no botão de categoria


                //vai ter que ter um void que retorna true ou false
                if (prodDAO.ListaProdCat(value.Item2).Rows.Count != 0)
                {
                    BtnVoltar.Visible = true;
                    // só preciso saber se retorna true
                    AcrescentarButtons(prodDAO.ListaProdCat(value.Item2));
                }
                else if (catDAO.ListarCat(value.Item2,true).Rows.Count != 0)
                {
                    MessageBox.Show("Não existem produtos Cadastrados para essa categoria");
                }
                else
                {

                    //pensar em criar um void que retorna uma datatable em acrescentarbuttons e depois comparar aqui com flpintens.controls, tirando assim, a necessidade de uma variavel global de lista
                    if (!listaitens.Contains(value.Item2.ToString()))
                    {
                        Itens item = new Itens();
                        item.LblItem.Text = value.Item2.ToString();
                        FlpItens.Controls.Add(item);
                        BtnFinalizarpedido.Visible = true;
                        listaitens.Add(value.Item2.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show(sender.ToString() + " not found.");
            }
        }

        public void Excluiritem(string nome)
        {
            listaitens.Remove(nome);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FlpCategorias.Controls.Clear();
            CarregarCategorias();
            BtnVoltar.Visible = false;
        }

        private void FlpItens_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (FlpItens.Controls.Count == 0)
            {
                BtnFinalizarpedido.Visible = false;
            }
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria i = new FrmCategoria();
            i.ShowDialog();
        }

        public void AcrescentarButtons(DataTable lista)
        {

            var orientation = SystemInformation.ScreenOrientation;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int i = 0;
            FlpCategorias.Controls.Clear();
            //  DataTable listaDescripto;
            while (FlpCategorias.Controls.Count < lista.Rows.Count)
            {
                Button dynamicButton = new Button();
                int x = screenWidth - (screenWidth * 30 / 100), y = screenHeight - (screenHeight * 30 / 100);

                if (orientation.ToString() == "Angle0")
                {
                    dynamicButton.Width = (x / 5) - 10;
                    dynamicButton.Height = (y / 3);
                }
                else if (orientation.ToString() == "Angle90")
                {
                    dynamicButton.Width = (x / 3) - 10;
                    dynamicButton.Height = (y / 5);
                }

                dynamicButton.Text = lista.Rows[i]["nome"].ToString();
                //try catch provisóirio
                try
                {
                    string path = lista.Rows[i]["imagem"].ToString();

                    if (File.Exists(path))
                    {
                        dynamicButton.BackgroundImage = Image.FromFile(path);
                        dynamicButton.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                catch
                {

                }

                dynamicButton.Font = new Font("Arial", 12);
                dynamicButton.TextAlign = ContentAlignment.TopCenter;
                Params.Add(dynamicButton, new Tuple<int, string>(1, dynamicButton.Text));
                dynamicButton.Click += DynamicButton_Click;
                FlpCategorias.Controls.Add(dynamicButton);

                i++;
            }
        }
    }
}
