using Orders.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrmLoginMesa : Form
    {
        readonly UsuarioDAO usuDAO = new UsuarioDAO();
        public FrmLoginMesa()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = cmbLogin.Text;
            string senha = txtSenha.Text;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha) && usuDAO.Verifica(login, senha))
            {
               
                    UsuarioDAO.login = usuDAO.Usu.Login_usu;
                    UsuarioDAO.tipo = usuDAO.Usu.Tipo;
                    UsuarioDAO.Id = usuDAO.Usu.Id_usu;
                    FrmCatalogo f = new FrmCatalogo();
                    f.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Usuário incorreto ou senha incorreta!");
                txtSenha.Clear();
            }
        }

        private void FrmLoginMesa_Load(object sender, EventArgs e)
        {
            AcrescentarMesa(usuDAO.ListarMesas());
        }

        public void AcrescentarMesa(DataTable lista)
        {
            cmbLogin.Items.Clear();

            // Percorrer os itens da tabela e adicionar ao ComboBox
            foreach (DataRow row in lista.Rows)
            {
                // Obter o valor da coluna desejada, supondo que seja "nome_da_mesa"
                string mesa = row["login"].ToString();

                // Adicionar o valor ao ComboBox
                cmbLogin.Items.Add(mesa);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
