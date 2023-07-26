using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioCuentaEmpresas
    {
        private List<CuentaEmpresa> cuentaEmpresas;

        public RepositorioCuentaEmpresas()
        {
            cuentaEmpresas = new List<CuentaEmpresa>();
        }

        public ReadOnlyCollection<CuentaEmpresa> ListarCuentaEmpresas() 
        {
            return cuentaEmpresas.AsReadOnly(); 
        }

        public bool Agregar(CuentaEmpresa cuentaEmpresa)
        {
            var cuentaExistente = cuentaEmpresas.FirstOrDefault(cuenta => cuenta.Numero == cuentaEmpresa.Numero);
            if (cuentaExistente == null)
            {
                cuentaEmpresas.Add(cuentaEmpresa);
                return true;
            }
            return false;
        }

        public bool Quitar(CuentaEmpresa cuentaEmpresa)
        {
            var cuentaExistente = Buscar(cuentaEmpresa.Numero);
            if (cuentaExistente != null)
            {
                cuentaEmpresas.Remove(cuentaExistente);
                return true;
            }
            return false;
        }

        public bool Quitar(int numero)
        {
            var cuentaExistente = Buscar(numero);
            if (cuentaExistente != null)
            {
                cuentaEmpresas.Remove(cuentaExistente);
                return true;
            }
            return false;
        }

        public CuentaEmpresa Buscar(int numero)
        {
            return cuentaEmpresas.FirstOrDefault(cuenta => cuenta.Numero == numero);
        }

        public bool Modificar(CuentaEmpresa cuentaEmpresa)
        {
            var cuentaExistente = Buscar(cuentaEmpresa.Numero);//1
            if (cuentaExistente != null)
            {
                cuentaEmpresas.Remove(cuentaEmpresa);
                cuentaEmpresas.Add(cuentaEmpresa);
                return true;
            }
            return false;
        }
    }
}
