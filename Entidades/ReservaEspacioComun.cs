using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReservaEspacioComun
    {
        public EspacioComun  EspacioReserva { get; set; }
        public DateTime FechaHora { get; set; }
        public bool DiaCompleto { get; set; }
        public int Duracion { get; set; }

        public Consorcista  Utiliza { get; set; }
    }
}
