using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consorcio : ClaseBase
    {
        #region DatosFiscales
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEscritura { get; set; }
        public string CUIT { get; set; }

        public Domicilio objDomicilio { get; set; }

        public List<CuentaBancaria> ListaCuentasBancarias { get; set; }
        #endregion
        
        #region DatosOperativos
        public List<Unidad> ListaUnidades { get; set; }
        public List<EspacioComun> ListaEspaciosComunes { get; set; }
        
        public List<Empleado> ListaEmpleados { get; set; }
        
        public List<Proveedor> ListaProveedores { get; set; }
        #endregion
        
        #region DatosCalculados
        public int CantidadDepartamentos()
        {
            int intCantDeptos = 0;
            if (ListaUnidades != null)
            {
                intCantDeptos = ListaUnidades.Count(x => x.GetType() == typeof(Departamento));
            }
            return intCantDeptos;
        }
        public int CantidadOficinas()
        {
            int intCantDeptos = 0;
            if (ListaUnidades != null)
            {
                intCantDeptos = ListaUnidades.Count(x => x.GetType() == typeof(Oficina));
            }
            return intCantDeptos;
        }
        public int CantidadCocheras()
        {
            int intCantDeptos = 0;
            if (ListaUnidades != null)
            {
                intCantDeptos = ListaUnidades.Count(x => x.GetType() == typeof(Cochera));
            }
            return intCantDeptos;
        }

        #endregion
    }
}
