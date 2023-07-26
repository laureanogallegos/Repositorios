using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Composicion
{
    internal class ItemFactura
    {

        private int cantidad;
        private Producto producto;
        public int Cantidad { get => cantidad; set => cantidad = value; }
        internal Producto Producto { get => producto; set => producto = value; }
    }
}
