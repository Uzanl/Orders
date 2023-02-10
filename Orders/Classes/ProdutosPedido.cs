using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Classes
{
    class Produtospedido
    {
        int id_pedido;
        int id_produto;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
    }
}
