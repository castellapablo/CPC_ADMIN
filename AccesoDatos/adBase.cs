using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAPA
{
    public class adBase
    {
        public int GetNuevoIDsinNumerador(string NombreTabla)
        {
            int intNuevoID;
            //conexion a la base de datos
            MySqlConnection conn = Configuracion.CrearConexionBD();
            conn.Open();

            using (conn)
            {
                //Creamos un commando para realizar el select
                MySqlCommand command = new MySqlCommand();
                using (command)
                {
                    //asignamos la conexion de trabajo
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;

                    //QUERY
                    StringBuilder sblSQL = new StringBuilder();
                    sblSQL.Append("SELECT MAX(ID) ");
                    sblSQL.Append("FROM " + NombreTabla);
                    command.CommandText = sblSQL.ToString();
                    object objID = command.ExecuteScalar();
                    if (objID == DBNull.Value)
                        intNuevoID = 1;
                    else
                        intNuevoID = Convert.ToInt32(objID) + 1;

                    return intNuevoID;
                }
            }
        }
    }
}
