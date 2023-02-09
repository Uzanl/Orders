using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Orders.Classes
{
     class Marca
    {
        int id_marca;
        string nome;

        public int Id_marca { get => id_marca; set => id_marca = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
