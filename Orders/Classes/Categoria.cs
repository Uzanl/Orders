namespace Orders.Classes
{
    class Categoria
    {
        int id_categoria;
        string nome;
        string imagem;
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Imagem { get => imagem; set => imagem = value; }
    }
}
