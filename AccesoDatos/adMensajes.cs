using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;
using System.Data;

namespace AccesoDatosAPA
{
    public class adMensajes : adBase
    {
        #region Mensajes
        public List<Mensaje> getMensajes(bool SoloActivos)
        {
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
                    sblSQL.Append("SELECT m.ID, m.Nombre, m.Pais, m.Email, m.Mensaje, m.FechaAlta ");
                    sblSQL.Append("FROM Mensajes m ");
                    sblSQL.Append("WHERE 1=1 ");
                    if (SoloActivos)
                    {
                        sblSQL.Append(" AND m.Estado = 'ACT' ");
                    }
                    sblSQL.Append("ORDER BY m.ID ");
                    command.CommandText = sblSQL.ToString();

                    //el datareader me permite cargar un datatable o un dataset desde un origen de datos. Esto mediante el método Load del dt/ds. !!!
                    MySqlDataReader myDR = command.ExecuteReader();

                    //creo un datatable
                    DataTable dtDatos = new DataTable();
                    //cargo los datos en el datatable con el datareader 
                    dtDatos.Load(myDR);

                    //Cargo la lista
                    List<Mensaje> lst = new List<Mensaje>();

                    if (dtDatos.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtDatos.Rows.Count; i++)
                        {
                            DataRow row = dtDatos.Rows[i];

                            //Creo y cargo el obj
                            Mensaje obj = new Mensaje();
                            obj.ID = Convert.ToInt32(row["ID"]);
                            obj.Nombre = Convert.ToString(row["Nombre"]);
                            obj.Pais = Convert.ToString(row["Pais"]);
                            obj.Msg = Convert.ToString(row["Mensaje"]);
                            obj.Email = Convert.ToString(row["Email"]);
                            obj.FechaAlta = Convert.ToDateTime(row["FechaAlta"]);

                            //agrego a la colección
                            lst.Add(obj);
                        }
                    }

                    //devuelvo la colección
                    return lst;
                }
            }

        }

        public Mensaje getMensaje(int ID)
        {
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
                    sblSQL.Append("SELECT m.ID, m.Nombre, m.Pais, m.Email, m.Mensaje, m.FechaAlta ");
                    sblSQL.Append("FROM Mensajes m ");
                    sblSQL.Append("WHERE m.ID = @ID ");
                    command.CommandText = sblSQL.ToString();

                    //params
                    command.Parameters.AddWithValue("@ID", ID);

                    //el datareader me permite cargar un datatable o un dataset desde un origen de datos. Esto mediante el método Load del dt/ds. !!!
                    MySqlDataReader myDR = command.ExecuteReader();


                    //creo un datatable
                    DataTable dtDatos = new DataTable();
                    //cargo los datos en el datatable con el datareader 
                    dtDatos.Load(myDR);
                    if (dtDatos.Rows.Count > 0)
                    {
                        DataRow row = dtDatos.Rows[0];

                        //Creo y cargo el obj
                        Mensaje obj = new Mensaje();
                        obj.ID = Convert.ToInt32(row["ID"]);
                        obj.Nombre = Convert.ToString(row["Nombre"]);
                        obj.Pais = Convert.ToString(row["Pais"]);
                        obj.Msg = Convert.ToString(row["Mensaje"]);
                        obj.Email = Convert.ToString(row["Email"]);
                        obj.FechaAlta = Convert.ToDateTime(row["FechaAlta"]);

                        //devuelvo el obj
                        return obj;
                    }

                    //no existe el id
                    return null;
                }
            }
        }

        public int InsertMensaje(Mensaje obj)
        {
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

                    //Busca ID
                    obj.ID = this.GetNuevoIDsinNumerador("Mensajes");

                    //QUERY
                    StringBuilder sblSQL = new StringBuilder();
                    sblSQL.Append("INSERT INTO Mensajes (ID, Nombre, Pais, Email, Mensaje, FechaAlta) ");
                    sblSQL.Append("VALUES (@ID, @Nombre, @Pais, @Email, @Mensaje, @FechaAlta) ");

                    //params
                    command.Parameters.AddWithValue("@ID", obj.ID);
                    command.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    command.Parameters.AddWithValue("@Pais", obj.Pais);
                    command.Parameters.AddWithValue("@Email", obj.Email);
                    command.Parameters.AddWithValue("@Mensaje", obj.Msg);
                    command.Parameters.AddWithValue("@FechaAlta", obj.FechaAlta);
                    command.CommandText = sblSQL.ToString();

                    //Ejecuta
                    int intResult = command.ExecuteNonQuery();

                    //retorna resultado
                    return intResult;
                }
            }
        }
        #endregion

    }
}
