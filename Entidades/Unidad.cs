using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Unidad : ClaseBase
    {
        public List<Propietario> ListaPropietarios { get; set; }
        public List<Inquilino> ListaInquilinos { get; set; }

        public decimal PorcentajeConsorcio { get; set; }
        public decimal MetrosCuadrados { get; set; }
    }
}
