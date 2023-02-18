using MySql.Data.MySqlClient;
using Orders.Classes;
using System;
using System.Data;


namespace Orders.ClassesDAO
{
    class ProdutoDAO
    {
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        Produto prod = new Produto();
        internal Produto Prod { get => prod; set => prod = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            executar_comando = new MySqlCommandBuilder(comando_sql);
            comando_sql.Fill(tabela_memoria);
        }

        #region VERIFICA NOMEPESQ
        public DataTable VerificaNOMEPESQ(string nome)
        {
            DataTable listaDescripto;
            executarComando("select p.nome as NOME from produto p inner join categoria c ON c.id_categoria = p.id_categoria WHERE c.nome='" + nome + "';");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["NOME"] = tabela_memoria.Rows[i]["NOME"].ToString();
               
                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion

    }
}
