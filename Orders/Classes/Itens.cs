﻿using Orders.ClassesDAO;
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
        public Itens()
        {
            InitializeComponent();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            int quantidade = MAIN.Quantidade(Convert.ToInt32(Tag));
            ped.Subtotal -= Convert.ToDouble(LblPreco.Text) * quantidade;
            MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
            MAIN.Excluiritem(Convert.ToInt32(Tag),iteminicial,true);

            
            Controls.Clear();
            Dispose();
        }

        private void Btnmais_Click(object sender, EventArgs e)
        {
           
             FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            MAIN.AcrescentarItens(Convert.ToInt32(Tag),LblItem.Text,LblPreco.Text,true);
            double x = ped.Subtotal;
            double y = Convert.ToDouble(LblPreco.Text);
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

                ped.Subtotal = Convert.ToDouble(LblPreco.Text);
                //       MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
            }
            else
            {
                double x = ped.Subtotal;
                double y = Convert.ToDouble(LblPreco.Text);
                double sum = x + y;
                //        MAIN.LblSubtotal.Text = $"Subtotal:{sum:C2}";
                ped.Subtotal = sum;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            FrmCatalogo MAIN = ParentForm as FrmCatalogo;
            ped.Subtotal -= Convert.ToDouble(LblPreco.Text);
            MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
            MAIN.Excluiritem(Convert.ToInt32(Tag),iteminicial,false);
          //  double x = ped.Subtotal;
           // double y = Convert.ToDouble(LblPreco.Text);
           // double sum = x - y;
            MAIN.LblSubtotal.Text = $"Subtotal:{ped.Subtotal:C2}";
           // ped.Subtotal = sum;
            int quantidade = MAIN.Quantidade(Convert.ToInt32(Tag));
            LblItem.Text = $"{quantidade}x {iteminicial}";
        }
    }
}
