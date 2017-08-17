using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocumentoIdentidad
    {
        public Constantes.TiposDocumentos.Valores TipoDocumento { get; set; }

        public string NroDocumento { get; set; }

        public bool EsPrincipal { get; set; }
    }
}
