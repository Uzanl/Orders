using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Classes
{
    class Ingrediente
    {
        int id_ingrediente;
        string  nome;

        public int Id_ingrediente { get => id_ingrediente; set => id_ingrediente = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
