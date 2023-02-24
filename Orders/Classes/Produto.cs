namespace Orders.Classes
{
    class Produto
    {
        int id_produto;
        string nome;
        int id_marca;
        int id_categoria;
        string imagem;
        string preco;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Id_marca { get => id_marca; set => id_marca = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public string Preco { get => preco; set => preco = value; }
    }
}
