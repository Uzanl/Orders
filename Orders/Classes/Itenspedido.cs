using System;
using System.Windows.Controls;

namespace Orders.Classes
{
    public class Itenspedido : UserControl 
    {

        int id_produto;
        string nome;
        int quantidade;
   

        public Itenspedido(int p, string n, int q)
        {
            Id_produto = p;
            Nome = n;
            Quantidade = q;
        }

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public bool Equals(Itenspedido other)
        {
            if (Id_produto == other.Id_produto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
