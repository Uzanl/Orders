namespace Orders.Classes
{
    class Produtospedido
    {
        int id_pedido;
        int id_produto;
        int quantidade;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
