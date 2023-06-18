using Orders.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Orders.ClassesDAO
{
    class UsuarioDAO
    {
        Usuario usu = new Usuario();
        MySqlDataAdapter comando_sql;
        DataTable tabela_memoria;

        internal Usuario Usu { get => usu; set => usu = value; }

        private static Boolean existe;

        public static string Login { get => login; set => login = value; }
        public static bool Existe { get => existe; set => existe = value; }
        public static string Tipo { get => tipo; set => tipo = value; }
        public static int Id { get => id; set => id = value; }

        public static string login;

        public static string tipo;

        private static int id;

        private void ExecutarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            comando_sql.Fill(tabela_memoria);
        }

        #region VERIFICA LOGIN E SENHA
        public bool Verifica(string login, string senha)
        {

            ExecutarComando("select id_usu, login_usu, tipo from usuario where login_usu='" + login + "' and senha_usu='" + senha + "' and status='Ativo';");
            try
            {

                usu.Login_usu = tabela_memoria.Rows[0]["login_usu"].ToString();
                usu.Tipo = tabela_memoria.Rows[0]["tipo"].ToString();
                usu.Id_usu = Convert.ToInt32(tabela_memoria.Rows[0]["id_usu"].ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region VERIFICA CARGO
        public Boolean VerificaCargo(string login)
        {

            ExecutarComando("select tipo from usuario where login_usu='" + login + "';");
            try
            {
                usu.Tipo = tabela_memoria.Rows[0]["tipo"].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region VERIFICA EXISTE
        public Boolean VerificaExiste()
        {
            ExecutarComando("select * from usuario;");
            try
            {
                usu.Login_usu = tabela_memoria.Rows[0]["login_usu"].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region INSERIR NOVO USUÁRIO
        public void Inserir(Usuario usu)
        {
            ExecutarComando("INSERT INTO USUARIO VALUES(0,'" + usu.Login_usu + "','" + usu.Senha_usu + "','" + usu.Tipo + "','" + usu.Status + "');");
        }
        #endregion

        #region LISTAR TUDO
        public DataTable ListarTudo()
        {
            DataTable listaDescripto;
            ExecutarComando("SELECT id_usu as ID,login_usu as LOGIN FROM USUARIO;");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();

                linha["ID"] = tabela_memoria.Rows[i]["ID"].ToString();
                linha["LOGIN"] = tabela_memoria.Rows[i]["LOGIN"].ToString();

                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion

        #region LISTAR MESA
        public DataTable ListarMesas()
        {
            DataTable listaDescripto;
            ExecutarComando("SELECT id_usu as ID, login_usu as LOGIN FROM USUARIO WHERE tipo ='mesa';");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();

                linha["ID"] = tabela_memoria.Rows[i]["ID"].ToString();
                linha["LOGIN"] = tabela_memoria.Rows[i]["LOGIN"].ToString();

                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion

        #region EXCLUIR
        public void Excluir(string id)
        {
            ExecutarComando("DELETE FROM USUARIO WHERE id_usu ='" + id + "';");
        }
        #endregion
    }
}
