using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Expensa
    {
        #region DatosEncabezado
        public Consorcio ConsorcioExpensa { get; set; }

        public DateTime FechaCierre { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public bool EsExtraOrdinaria { get; set; }
        public bool EsOrdinaria
        {
            get { return !EsExtraOrdinaria; }
        }

        public DateTime FechaVto1 { get; set; }
        public DateTime FechaVto2 { get; set; }

        public string Observaciones { get; set; }
        #endregion

        //public decimal TasaInteres { get; set; }

        #region DatosDetalle
        //public List<ExpensaUnidad> ListaExpensasUnidades { get; set; }

        public List<Gasto> ListaGastos { get; set; }
        #endregion

        #region DatosCalculados
        public decimal TotalGeneral()
        {
            decimal decTotal = 0;
            if (ListaGastos != null)
            {
                decTotal = ListaGastos.Sum(x => x.Monto);
            }
            return decTotal;
        }
        public decimal TotalDeptos()
        {
            decimal decTotal = 0;
            if (ListaGastos != null)
            {
                decTotal = ListaGastos.Where(x => x.TipoGasto == Constantes.TiposGastos.Valores.General 
                                              || x.TipoGasto == Constantes.TiposGastos.Valores.SoloDeptos).Sum(x => x.Monto);
            }
            return decTotal;
        }
        public decimal TotalCocheras()
        {
            decimal decTotal = 0;
            if (ListaGastos != null)
            {
                decTotal = ListaGastos.Where(x => x.TipoGasto == Constantes.TiposGastos.Valores.General
                                              || x.TipoGasto == Constantes.TiposGastos.Valores.SoloCocheras).Sum(x => x.Monto);
            }
            return decTotal;
        }
        #endregion
    }
}
