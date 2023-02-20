﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Classes
{
    public class Itenspedido: IEquatable<Itenspedido>
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
