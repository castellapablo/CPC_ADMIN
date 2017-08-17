using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AccesoDatosAPA
{
    public class Configuracion
    {
        #region PROPIEDADES
        //Cadena de conexión
        const string connString = "BD_MySQL_CONNSTRING";
        #endregion

        #region METODOS
        //Obtiene la sección de configuración del archivo
        private static Configuration BuscarConfiguracion()
        {
            //Path del archivo de configuracion
            string path;

            //Objeto configuracion a devolver
            Configuration config;

            //Windows 
            path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName);
            //abrimos configuracion windows 
            config = System.Configuration.ConfigurationManager.OpenExeConfiguration(path);
         
            return config;
        }

        //Busca el conn string del archivo de configuración (app.config)
        public static String BuscarConnString(string key)
        {
            //Objeto configuracion 
            //Configuration config;

            //valor a devolver
            string value;
            try
            {
                //Obtengo configuracion 
                //config = BuscarConfiguracion();

                try
                {
                    //Obtengo el valor 
                    //value = config.AppSettings.Settings[key].Value;
                   // value = config.ConnectionStrings.ConnectionStrings[connString].ConnectionString;
                    value = System.Configuration.ConfigurationManager.ConnectionStrings[connString].ConnectionString ;
                }
                catch (Exception ex)
                {
                    //Si no existe creo una exception (KeyNotFoundException) 
                    throw new Exception(String.Format("Error: la clave '{0}' no existe en el archivo de configuracion.", key), ex);
                }
                return value;
            }
            finally
            {            
            }
        }

        //Crea una conexion en base a la cadena de conexion almacenada en el archivo de configuración
        public static MySqlConnection CrearConexionBD()
        {
            MySqlConnection oCnn;

            try
            {
                //Creamos  una conexion 
                oCnn = new MySqlConnection();

                //Asignamos el connectionString que se obtenido del archivo de configuracion de la capa de UI
                oCnn.ConnectionString = Configuracion.BuscarConnString(connString);

                //--directo (para pruebas nomás)--
                //oCnn.ConnectionString = "server=localhost; database=senzaparole; uid=root; pwd=pablo";

                //Retornamos el objeto conexion creado
                return oCnn;
            }
            finally
            {
                oCnn = null;
            }
        }

        #endregion
    }
}
