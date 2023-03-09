using Orders.Classes;
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
    public partial class FrmCadUsu : Form
    {
        UsuarioDAO usuDAO = new UsuarioDAO();
        Usuario usu = new Usuario();
        public FrmCadUsu()
        {
            InitializeComponent();
        }

        private void FrmCadUsu_Load(object sender, EventArgs e)
        {
            if (UsuarioDAO.Existe == false)
            {
                cmbCargo.Enabled = false;
                cmbCargo.SelectedIndex = 0;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            if (txtLogin.Text != string.Empty)
            {
                if (usuDAO.VerificaCargo(login) == true)
                {
                    txtLogin.BackColor = Color.Red;
                    btnCadastrar.Enabled = false;
                }
                else
                {
                    txtLogin.BackColor = Color.LightGreen;
                    btnCadastrar.Enabled = true;
                }
            }
            else
            {
                txtLogin.BackColor = Color.Empty;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.Empty;
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            #region MOSTRA SENHA
            if (chkSenha.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            #endregion
        }

        private void txtConfirma_TextChanged(object sender, EventArgs e)
        {
            txtConfirma.BackColor = Color.Empty;
        }

        private void txtConfirma_Leave(object sender, EventArgs e)
        {
            #region CONFIRMA SENHA
            if (txtConfirma.Text != txtSenha.Text)
            {
                MessageBox.Show("As senhas não confirmam !!!");
                txtConfirma.Clear();
            }
            #endregion
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCargo.BackColor = Color.Empty;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == string.Empty || txtSenha.Text == string.Empty || txtConfirma.Text == string.Empty
              || cmbCargo.Text == string.Empty)
            {
                if (txtLogin.Text == string.Empty)
                    txtLogin.BackColor = Color.Red;

                if (txtSenha.Text == string.Empty)
                    txtSenha.BackColor = Color.Red;

                if (txtConfirma.Text == string.Empty)
                    txtConfirma.BackColor = Color.Red;

                if (cmbCargo.Text == string.Empty)
                    cmbCargo.BackColor = Color.Red;

                MessageBox.Show("Favor preencher as informações");

            }
            else
            {
                try
                {
                    usu.Login_usu = txtLogin.Text;
                    usu.Senha_usu = txtConfirma.Text;
                    usu.Status = "Ativo";
                    usu.Tipo = cmbCargo.Text;
                    usuDAO.Inserir(usu);
                    MessageBox.Show("Usuário cadastrado com sucesso !!!");
                 //   Limpar();

                    if (UsuarioDAO.Existe == false)
                    {
                        Application.Restart();
                    }

                 //   if (UsuarioDAO.Existe == true)
                 //   {
                 //       aud.Acao = "CADASTROU USUARIO";
                  //      aud.Data = FechamentoDAO.data;
                  //      aud.Hora = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
                  //      aud.Responsavel = UsuarioDAO.login;
                 //       audDAO.Inserir(aud);
                  //  }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Favor verificar as informações digitadas !!!");
                }
            }
        }
    }
}
