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
    public partial class FrmLogin : Form
    {
        UsuarioDAO usuDAO = new UsuarioDAO();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            //fazer um tratamento caso não tenha nenhuma mesa cadastrada.
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha) && usuDAO.Verifica(login, senha))
            {
                if(usuDAO.Usu.Tipo == "Garçom" || usuDAO.Usu.Tipo == "Administrador"||usuDAO.Usu.Tipo =="Mesa")
                {
                    UsuarioDAO.login = usuDAO.Usu.Login_usu;
                    UsuarioDAO.tipo = usuDAO.Usu.Tipo;
                    UsuarioDAO.Id = usuDAO.Usu.Id_usu;
                    FrmCatalogo f = new FrmCatalogo();
                    f.ShowDialog();
                    Close();
                }else if (usuDAO.Usu.Tipo == "Chefe")
                {
                    UsuarioDAO.login = usuDAO.Usu.Login_usu;
                    UsuarioDAO.tipo = usuDAO.Usu.Tipo;
                    UsuarioDAO.Id = usuDAO.Usu.Id_usu;
                    FrmPedido f = new FrmPedido();
                    f.ShowDialog();
                    Close();
                }

               
               
            }
            else
            {
                MessageBox.Show("Usuário incorreto ou senha incorreta!");
                txtSenha.Clear();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoginMesa m = new FrmLoginMesa();
            m.ShowDialog();
            Close();
        }
    }
}
