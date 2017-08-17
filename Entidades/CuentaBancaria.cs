using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaBancaria
    {
        public Banco objBanco { get; set; }

        public string Sucursal { get; set; }
        public string TipoCuenta { get; set; }
        public string NroCuenta { get; set; }
        public string CBU { get; set; }
    }
}
