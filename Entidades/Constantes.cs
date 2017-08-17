using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Constantes
    {
        /// <summary>
        /// Tipo de Gasto
        /// </summary>
        public class TiposGastos
        {
            public class TiposGastos_E
            {
                private short _id;
                public short ID
                {
                    get { return _id; }
                    set { _id = value; }
                }

                private string _desc;
                public string DESCRIPCION
                {
                    get { return _desc; }
                    set { _desc = value; }
                }
            }

            public enum Valores : short
            {
                IND = 0,
                General = 1,
                SoloDeptos = 2,
                SoloCocheras = 3
            }

            public static short RecuperarID(string valorSTR)
            {
                switch (valorSTR)
                {
                    case "IND":
                        return 0;
                    case "General":
                        return 1;
                    case "SoloDeptos":
                        return 2;
                    case "SoloCocheras":
                        return 3;
                }

                throw new NotImplementedException();
            }

            public static string RecuperarDescripcion(short valor)
            {
                switch (valor)
                {
                    case 1:
                        return "General";
                    case 2:
                        return "Solo Deptos.";
                    case 3:
                        return "Solo Cocheras";
                }

                throw new NotImplementedException();
            }

            public static List<TiposGastos.TiposGastos_E> CrearDataSource(bool todos, string valortodos)
            {
                List<TiposGastos.TiposGastos_E> lstDS = new List<TiposGastos.TiposGastos_E>();
                TiposGastos.TiposGastos_E objDS = null;
                if (todos)
                {
                    objDS = new TiposGastos.TiposGastos_E();
                    objDS.ID = Convert.ToInt16(TiposGastos.Valores.IND);
                    objDS.DESCRIPCION = valortodos;
                    lstDS.Add(objDS);
                }
                foreach (TiposGastos.Valores intTipo in Enum.GetValues(typeof(TiposGastos.Valores)))
                {
                    if (intTipo != TiposGastos.Valores.IND)
                    {
                        objDS = new TiposGastos.TiposGastos_E();
                        objDS.ID = Convert.ToInt16(intTipo);
                        objDS.DESCRIPCION = TiposGastos.RecuperarDescripcion(Convert.ToInt16(intTipo));
                        lstDS.Add(objDS);
                    }
                }
                return lstDS;
            }
        }

        /// <summary>
        /// Tipo de Gasto
        /// </summary>
        public class TiposDocumentos
        {
            public class TiposDocumentos_E
            {
                private short _id;
                public short ID
                {
                    get { return _id; }
                    set { _id = value; }
                }

                private string _desc;
                public string DESCRIPCION
                {
                    get { return _desc; }
                    set { _desc = value; }
                }
            }

            public enum Valores : short
            {
                IND = 0,
                DNI = 1,
                LE = 2,
                LC = 3,
                PAS = 4,
                CUIL = 5,
                CUIT = 6,
                CI = 7,
                DNI_EXT = 8,
                OTRO = 9
            }

            public static short RecuperarID(string valorSTR)
            {
                switch (valorSTR)
                {
                    case "IND":
                        return 0;
                    case "DNI":
                        return 1;
                    case "LE":
                        return 2;
                    case "LC":
                        return 3;
                    case "PAS":
                        return 4;
                    case "CUIL":
                        return 5;
                    case "CUIT":
                        return 6;
                    case "CI":
                        return 7;
                    case "DNI_EXT":
                        return 8;
                    case "OTRO":
                        return 9;
                }

                throw new NotImplementedException();
            }

            public static string RecuperarDescripcion(short valor)
            {
                switch (valor)
                {
                    case 1:
                        return "DNI";
                    case 2:
                        return "Libreta Enrolamiento";
                    case 3:
                        return "Libreta Cívica";
                    case 4:
                        return "Pasaporte";
                    case 5:
                        return "CUIL";
                    case 6:
                        return "CUIT";
                    case 7:
                        return "Cédula Identidad";
                    case 8:
                        return "DNI Extranjero";
                    case 9:
                        return "Otro";
                }

                throw new NotImplementedException();
            }

            public static List<TiposDocumentos.TiposDocumentos_E> CrearDataSource(bool todos, string valortodos)
            {
                List<TiposDocumentos.TiposDocumentos_E> lstDS = new List<TiposDocumentos.TiposDocumentos_E>();
                TiposDocumentos.TiposDocumentos_E objDS = null;
                if (todos)
                {
                    objDS = new TiposDocumentos.TiposDocumentos_E();
                    objDS.ID = Convert.ToInt16(TiposDocumentos.Valores.IND);
                    objDS.DESCRIPCION = valortodos;
                    lstDS.Add(objDS);
                }
                foreach (TiposDocumentos.Valores intTipo in Enum.GetValues(typeof(TiposDocumentos.Valores)))
                {
                    if (intTipo != TiposDocumentos.Valores.IND)
                    {
                        objDS = new TiposDocumentos.TiposDocumentos_E();
                        objDS.ID = Convert.ToInt16(intTipo);
                        objDS.DESCRIPCION = TiposDocumentos.RecuperarDescripcion(Convert.ToInt16(intTipo));
                        lstDS.Add(objDS);
                    }
                }
                return lstDS;
            }
        }
    }
}
