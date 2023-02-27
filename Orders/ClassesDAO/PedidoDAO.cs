using MySql.Data.MySqlClient;
using Orders.Classes;
using System;
using System.Data;

namespace Orders.ClassesDAO
{
    class PedidoDAO
    {
        MySqlDataAdapter comando_sql;
        DataTable tabela_memoria;

        Pedido ped = new Pedido();

        internal Pedido Ped { get => ped; set => ped = value; }

        private void ExecutarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            comando_sql.Fill(tabela_memoria);
        }

        #region INSERIR NOVO PEDIDO
        public void Inserir(Pedido ped)
        {
            ExecutarComando("INSERT INTO PEDIDO VALUES(0,'" + ped.Id_cliente + "','" + ped.Data_pedido.ToString("yyyy/MM/dd") + "','" + ped.Hora.ToString("HH:mm") + "');");
        }
        #endregion


        public bool Ultimopedido()
        {
            ExecutarComando("select MAX(id_pedido) from pedido");
            try
            {
                Ped.Id_pedido = Convert.ToInt32(tabela_memoria.Rows[0]["MAX(id_pedido)"].ToString());

                return true;
            }
            catch
            {
                return false;
            }
        }

        #region LISTA PEDIDOS NA DATA CORRENTE
        public DataTable ListaPedData(DateTime data)
        {
            DataTable listaDescripto;
            ExecutarComando("select p.id_pedido as ID, c.nome as CLIENTE, p.hora as HORA, p.hora as HORA from pedido p inner join cliente c on c.id_cliente = p .id_cliente WHERE p.data_pedido ='" + data.ToString("yyyy/MM/dd") + "';");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["ID"] = tabela_memoria.Rows[i]["ID"].ToString();
                linha["CLIENTE"] = tabela_memoria.Rows[i]["CLIENTE"].ToString();
                linha["HORA"] = tabela_memoria.Rows[i]["HORA"].ToString();

                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion
    }
}
