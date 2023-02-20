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

        #region INSERIR NOVA CATEGORIA
        public void Inserir(Produtospedido prodped)
        {
            ExecutarComando("INSERT INTO PRODUTOS_PEDIDO VALUES('" + prodped.Id_pedido + "','" +prodped.Id_produto + "');");
        }
        #endregion
    }
}
