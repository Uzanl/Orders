using System;
using System.Data;
using MySql.Data.MySqlClient;
using Orders.Classes;


namespace Orders.ClassesDAO
{
    class ProdutoDAO
    {
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        Produto prod = new Produto();
        internal Produto Prod { get => prod; set => prod = value; }
        public DataTable Listaproduto { get => listaproduto; set => listaproduto = value; }
    
        DataTable listaproduto;

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            executar_comando = new MySqlCommandBuilder(comando_sql);
            comando_sql.Fill(tabela_memoria);
        }

        #region VERIFICA NOMEPESQ
        public Boolean VerificaNOMEPESQ(string nome)
        {
            executarComando("select p.nome as NOME from produto p inner join categoria c ON c.id_categoria = p.id_categoria WHERE c.nome='" + nome + "';");
            try
            {
                //pes.Id_pessoa = Convert.ToInt32(tabela_memoria.Rows[0]["ID"]);

                prod.Nome = tabela_memoria.Rows[0]["NOME"].ToString();
             


                if (tabela_memoria.Rows.Count > 1)
                {
                    listaproduto = tabela_memoria;
                }
                else
                {
                    listaproduto = null;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
