using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositorios
{
    public partial class Form1 : Form
    {
        private RepositorioCuentaEmpresas repositorioCuentaEmpresas;
        private RepositorioCuentaPersonales repositorioCuentaPersonales;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repositorioCuentaEmpresas = new Modelo.RepositorioCuentaEmpresas();
            Modelo.CuentaEmpresa cuentaEmpresa = new Modelo.CuentaEmpresa();
            cuentaEmpresa.Numero = 123;
            Modelo.CuentaEmpresa cuentaEmpresa1 = new Modelo.CuentaEmpresa();
            cuentaEmpresa1.Numero = 123;
            Modelo.CuentaEmpresa cuenta = cuentaEmpresa;
            cuentaEmpresa.Numero = 456;
            var resultado1 = repositorioCuentaEmpresas.Agregar(cuentaEmpresa);
            var resultado2 = repositorioCuentaEmpresas.Agregar(cuentaEmpresa1);
            var resultado3 = repositorioCuentaEmpresas.Agregar(cuenta);

            var eliminadoCorrectamente = repositorioCuentaEmpresas.Quitar(123);
            repositorioCuentaEmpresas.ListarCuentaEmpresas();
            var cuentaEmpresaEncontrada = repositorioCuentaEmpresas.Buscar(123);

        }
    }
}
