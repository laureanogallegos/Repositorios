using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Composicion
{
    internal class Producto
    {
        private decimal precio;
        private string codigo;
        private int stock;
        public decimal Precio { get => precio; set => precio = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
