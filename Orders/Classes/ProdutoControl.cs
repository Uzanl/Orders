using Orders.ClassesDAO;
using System;
using System.Windows.Forms;

namespace Orders.Classes
{
    public partial class ProdutoControl : UserControl
    {
        ProdutoDAO prodDAO = new ProdutoDAO();
      
        public ProdutoControl()
        {
            InitializeComponent();
       
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult op;

            op = MessageBox.Show($"Deseja excluir {LblProduto.Text} ?",
                "Excluir?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                prodDAO.Excluir(Convert.ToInt32(Tag));
                MessageBox.Show("Excluído com sucesso !!!");
                Dispose();
            }
        }
    }
}
