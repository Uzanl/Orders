using MySql.Data.MySqlClient;
using Orders.Classes;
using System;
using System.Data;


namespace Orders.ClassesDAO
{
    class ProdutoDAO
    {
        MySqlDataAdapter comando_sql;
        DataTable tabela_memoria;

        Produto prod = new Produto();
        internal Produto Prod { get => prod; set => prod = value; }

        private void ExecutarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            comando_sql.Fill(tabela_memoria);
        }


        #region VERIFICA SE A CATEGORIA TEM ALGUM PRODUTO
        public bool VerificaCategoria(string categoria)
        {
            ExecutarComando("select p.id_produto as ID from produto p inner join categoria c on c.id_categoria= p.id_categoria WHERE c.nome ='" + categoria + "';");
            try
            {
                Prod.Id_produto =Convert.ToInt32(tabela_memoria.Rows[0]["ID"]);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region VERIFICA SE A CATEGORIA TEM ALGUM PRODUTO POR ID
        public bool VerificaCategoriaId(int id_categoria)
        {
            ExecutarComando("select p.id_produto as ID from produto p inner join categoria c on c.id_categoria= p.id_categoria WHERE c.id_categoria ='" +id_categoria  + "';");
            try
            {
                Prod.Id_produto = Convert.ToInt32(tabela_memoria.Rows[0]["ID"]);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region LISTA PRODUTO POR CATEGORIA
        public DataTable ListaProdCat(string nome)
        {
            DataTable listaDescripto;
            ExecutarComando("select p.id_produto as ID,p.nome as NOME, p.imagem as IMAGEM, p.preco as PRECO from produto p inner join categoria c ON c.id_categoria = p.id_categoria WHERE c.nome='" + nome + "';");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["ID"] = tabela_memoria.Rows[i]["ID"].ToString();
                linha["NOME"] = tabela_memoria.Rows[i]["NOME"].ToString();
                linha["IMAGEM"] = tabela_memoria.Rows[i]["IMAGEM"].ToString();
                linha["PRECO"] = tabela_memoria.Rows[i]["PRECO"].ToString();

                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion

        #region LISTA PRODUTO POR CATEGORIA POR ID
        public DataTable ListaProdCatId(int id_categoria)
        {
            DataTable listaDescripto;
            ExecutarComando("select p.id_produto as ID,p.nome as NOME, p.imagem as IMAGEM, p.preco as PRECO from produto p inner join categoria c ON c.id_categoria = p.id_categoria WHERE c.id_categoria='" + id_categoria + "';");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["ID"] = tabela_memoria.Rows[i]["ID"].ToString();
                linha["NOME"] = tabela_memoria.Rows[i]["NOME"].ToString();
                linha["IMAGEM"] = tabela_memoria.Rows[i]["IMAGEM"].ToString();
                linha["PRECO"] = tabela_memoria.Rows[i]["PRECO"].ToString();

                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion

        #region LISTA PRODUTO LIKE POR CATEGORIA 
        public DataTable ListaProdCatLike(string categoria, string produto)
        {
            DataTable listaDescripto;
            ExecutarComando("select p.id_produto as ID,p.nome as NOME, p.imagem as IMAGEM from produto p inner join categoria c ON c.id_categoria = p.id_categoria WHERE c.nome ='" + categoria+"' AND p.nome LIKE'" + produto + "%';");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["ID"] = tabela_memoria.Rows[i]["ID"].ToString();
                linha["NOME"] = tabela_memoria.Rows[i]["NOME"].ToString();
                linha["IMAGEM"] = tabela_memoria.Rows[i]["IMAGEM"].ToString();

                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion

        #region INSERIR NOVO PRODUTO EM UMA CATEGORIA
        public void Inserir(Produto produto)
        {
            ExecutarComando("INSERT INTO PRODUTO VALUES(0,'" + produto.Nome + "','" + produto.Preco + "','"+produto.Imagem.Replace("\\", "/") + "',null,'"+produto.Id_categoria+"');");
        }
        #endregion
    }
}
