using Orders.Classes;
using Orders.ClassesDAO;
using System;
using System.Windows.Forms;

namespace Orders
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new FrmCatalogo());


            Conexao.Criar_Conexao();
            UsuarioDAO usuDAO = new UsuarioDAO();
            if (usuDAO.VerificaExiste() == true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                UsuarioDAO.Existe = true;
                Application.Run(new FrmLogin());
            }
           else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                UsuarioDAO.Existe = false;
                Application.Run(new FrmCadUsu());
            }

        }
    }
}
