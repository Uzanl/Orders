using System;
using System.Windows.Controls;

namespace Orders.Classes
{
    public class Itenspedido : UserControl 
    {

        int id_produto;
        string nome;


        public Itenspedido(int p, string n)
        {
            Id_produto = p;
            Nome = n;
        
        }

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Nome { get => nome; set => nome = value; }

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
