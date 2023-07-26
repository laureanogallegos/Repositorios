using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CuentaEmpresa
    {
        public int Numero { get; set; }
        public Banco Banco { get => banco; set => banco = value; }

        private Banco banco;
    }
}
