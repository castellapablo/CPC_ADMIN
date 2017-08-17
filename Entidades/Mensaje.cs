using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensaje
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        //public Country ResidenceCountry { get; set; }
        public string Email { get; set; }
        public string Msg { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
