using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Classes
{
    class Categoria
    {
        int id_categoria;
        string nome;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
