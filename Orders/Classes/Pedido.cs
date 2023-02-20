using System;

namespace Orders.ClassesDAO
{
    class Pedido
    {
        int id_pedido;
        int id_cliente;
        DateTime data_pedido;
        DateTime hora;

        public DateTime Data_pedido { get => data_pedido; set => data_pedido = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
    }
}
