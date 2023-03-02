using MySql.Data.MySqlClient;
using Orders.Classes;
using System.Data;

namespace Orders.ClassesDAO
{
    class ProdutospedidoDAO
    {
        MySqlDataAdapter comando_sql;
        DataTable tabela_memoria;

        Produtospedido prodped = new Produtospedido();

        internal Produtospedido Prodped { get => prodped; set => prodped = value; }

        private void ExecutarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            comando_sql.Fill(tabela_memoria);
        }

        #region INSERIR NOVO PEDIDO
        public void Inserir(Produtospedido prodped)
        {
            ExecutarComando("INSERT INTO PRODUTOS_PEDIDO VALUES(0,'" + prodped.Id_pedido + "','" + prodped.Id_produto + "');");
        }
        #endregion

        #region LISTA PRODUTO POR PEDIDO
        public DataTable ListaProdPed(int id)
        {
            DataTable listaDescripto;
            ExecutarComando("select p.id_produto as ID,p.nome AS PRODUTO,P.imagem as IMAGEM from produtos_pedido pp inner join produto p on p.id_produto = pp.id_produto inner join pedido pe on pe.id_pedido = pp.id_pedido WHERE pp.id_pedido ='" + id + "';");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["ID"] = tabela_memoria.Rows[i]["ID"].ToString();
                linha["PRODUTO"] = tabela_memoria.Rows[i]["PRODUTO"].ToString();
                linha["IMAGEM"] = tabela_memoria.Rows[i]["IMAGEM"].ToString();

                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion
    }
}
