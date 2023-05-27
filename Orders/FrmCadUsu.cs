using Google.Protobuf.WellKnownTypes;
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
            lbl1Num.ForeColor = Color.FromArgb(182, 53, 40);
            lbl8Caracteres.ForeColor = Color.FromArgb(182, 53, 40);
            lbl1Minuscula.ForeColor = Color.FromArgb(182, 53, 40);
            lblMaiuscula.ForeColor = Color.FromArgb(182, 53, 40);
            lbl1Especial.ForeColor = Color.FromArgb(182, 53, 40);
            lbl8Caracteres.ForeColor = Color.FromArgb(182, 53, 40);

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

        bool IsNumber(TextBox text)
        {
            foreach (var item in text.Text.Reverse())
                if (char.IsNumber(item)) { return true; }
            return false;
        }

        bool IsLower(TextBox text)
        {
            foreach (var item in text.Text.Reverse())
                if (char.IsLower(item)) { return true; }
            return false;
        }

        bool IsUpper(TextBox text)
        {
            foreach (var item in text.Text.Reverse())
                if (char.IsUpper(item)) { return true; }
            return false;
        }

        bool IsSymbol(TextBox text)
        {
            foreach (var item in text.Text.Reverse())
                if (char.IsSymbol(item)) { return true; }
            return false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if(txtSenha.Text.Length> 8)
            {
                lbl8Caracteres.ForeColor = Color.FromArgb(0, 189, 83);
            }
            else
            {
                lbl8Caracteres.ForeColor = Color.FromArgb(182, 53, 40);
            }

            if (IsNumber(txtSenha))
            {
                lbl1Num.ForeColor = Color.FromArgb(0,189,83);
            }
            else
            {
                lbl1Num.ForeColor = Color.FromArgb(182, 53, 40);
            }

            if (IsLower(txtSenha))
            {
                lbl1Minuscula.ForeColor = Color.FromArgb(0, 189, 83);
            }
            else
            {
                lbl1Minuscula.ForeColor = Color.FromArgb(182, 53, 40);
            }

            if (IsUpper(txtSenha))
            {
                lblMaiuscula.ForeColor = Color.FromArgb(0, 189, 83);
            }
            else
            {
                lblMaiuscula.ForeColor = Color.FromArgb(182, 53, 40);
            }

            if (IsSymbol(txtSenha))
            {
                lbl1Especial.ForeColor = Color.FromArgb(0, 189, 83);
            }
            else
            {
                lbl1Especial.ForeColor = Color.FromArgb(182, 53, 40);
            }

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
                    Limpar();

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

        public void Limpar()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtConfirma.Clear();
            cmbCargo.Items.Clear();
            chkSenha.Checked = false;
        }
    }
}
