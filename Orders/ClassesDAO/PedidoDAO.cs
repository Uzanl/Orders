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
            ExecutarComando("INSERT INTO PEDIDO VALUES(0,'" + ped.Id_cliente + "','" + ped.Data_pedido.ToString("yyyy/MM/dd") + "','"+ped.Hora.ToString("HH:mm")+"');");
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
    }
}
