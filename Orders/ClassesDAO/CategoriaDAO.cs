using MySql.Data.MySqlClient;
using Orders.Classes;
using System.Data;

namespace Orders.ClassesDAO
{
    class CategoriaDAO
    {
        MySqlDataAdapter comando_sql;
        DataTable tabela_memoria;

        Categoria cat = new Categoria();
        internal Categoria Cat { get => cat; set => cat = value; }


        private void ExecutarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            comando_sql.Fill(tabela_memoria);
        }

        #region LISTA CATEGORIAS E LIKE
        public DataTable ListarCat(string categoria, bool produto)
        {

            // talvez usar uma strig no lugar do where nome like, where nome e categoria para evitar repetição de código
            DataTable listaDescripto;
            if (categoria == string.Empty)
            {

                ExecutarComando("SELECT id_categoria as ID,nome as NOME, imagem as IMAGEM FROM CATEGORIA;");
                listaDescripto = tabela_memoria.Clone();
            }
            else if (produto == false && categoria != string.Empty)
            {

                ExecutarComando("SELECT  id_categoria as ID, nome as NOME, imagem as IMAGEM FROM CATEGORIA WHERE NOME LIKE '" + categoria + "%';");
                listaDescripto = tabela_memoria.Clone();
            }
            else
            {

                ExecutarComando("SELECT  id_categoria as ID, nome as NOME, imagem as IMAGEM FROM CATEGORIA WHERE NOME = '" + categoria + "%';");
                listaDescripto = tabela_memoria.Clone();
            }
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["ID"] = tabela_memoria.Rows[i]["ID"].ToString();
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
            ExecutarComando("INSERT INTO CATEGORIA VALUES(0,'" + cat.Nome + "','" + cat.Imagem.Replace("\\", "/") + "');");
        }
        #endregion
    }
}
