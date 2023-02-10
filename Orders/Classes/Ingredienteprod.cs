using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Classes
{
    internal class Ingredienteprod
    {
        int id_ingrediente;
       
        int id_produto;

        public int Id_ingrediente { get => id_ingrediente; set => id_ingrediente = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
    }
}
