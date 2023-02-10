using System;
using System.Data;
using MySql.Data.MySqlClient;
using Orders.Classes;

namespace Orders.ClassesDAO
{
    class CategoriaDAO
    {
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        Categoria cat = new Categoria();
        internal Categoria Cat { get => cat; set => cat = value; }
        public DataTable Listacategoria { get => listacategoria; set => listacategoria = value; }

        DataTable listacategoria;

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            executar_comando = new MySqlCommandBuilder(comando_sql);
            comando_sql.Fill(tabela_memoria);
        }

        #region LISTA TODOS AS CATEGORIAS
        public DataTable ListarCategorias()
        {
            DataTable listaDescripto;
            executarComando("SELECT nome as NOME FROM CATEGORIA;");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["NOME"] = tabela_memoria.Rows[i]["NOME"].ToString();
                listaDescripto.Rows.Add(linha);
            }
            listacategoria = listaDescripto;
            return listaDescripto;
        }
        #endregion
    }
}
