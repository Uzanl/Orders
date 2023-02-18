using MySql.Data.MySqlClient;
using Orders.Classes;
using System.Data;

namespace Orders.ClassesDAO
{
    class CategoriaDAO
    {
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        Categoria cat = new Categoria();
        internal Categoria Cat { get => cat; set => cat = value; }
      

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
            executarComando("SELECT nome as NOME, imagem as IMAGEM FROM CATEGORIA;");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["NOME"] = tabela_memoria.Rows[i]["NOME"].ToString();
                linha["IMAGEM"] = tabela_memoria.Rows[i]["IMAGEM"].ToString().Replace("/", "\\");
                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion

        #region LISTA CATEGORIA POR NOME
        public DataTable ListarCatLike(string categoria)
        {
            DataTable listaDescripto;
            executarComando("SELECT nome as NOME, imagem as IMAGEM FROM CATEGORIA WHERE NOME LIKE '" + categoria + "%';");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["NOME"] = tabela_memoria.Rows[i]["NOME"].ToString();
                linha["IMAGEM"] = tabela_memoria.Rows[i]["IMAGEM"].ToString().Replace("/", "\\");
                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion

        #region INSERIR NOVA CATEGORIA
        public void Inserir(Categoria cat)
        {
            executarComando("INSERT INTO CATEGORIA VALUES(0,'" + cat.Nome + "','" + cat.Imagem.Replace("\\","/") + "');");
        }
        #endregion
    }
}
