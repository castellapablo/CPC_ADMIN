using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Departamento: Unidad
    {
        public string Bloque { get; set; }
        public string Piso { get; set; }
        public string Numero { get; set; }

        public int Ambientes { get; set; }
    }
}
