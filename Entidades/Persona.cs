using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public List<DocumentoIdentidad> ListaDocIdentidad { get; set; }

        public List<Domicilio> ListaDomicilios { get; set; }
        public List<Telefono> ListaTelefonos { get; set; }
        public List<Email> ListaMails { get; set; }
    }
}
