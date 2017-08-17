using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gasto
    {
        public decimal Monto { get; set; }

        public Proveedor ProveedorEjecutor { get; set; }

        public Constantes.TiposGastos.Valores  TipoGasto { get; set; }
    }
}
