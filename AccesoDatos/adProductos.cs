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
    public class adProductos
    {
        //#region ProductZone
        //public List<ProductZone> getProductZones(bool SoloActivos)
        //{
        //    //conexion a la base de datos
        //    MySqlConnection conn = Configuracion.CrearConexionBD();
        //    conn.Open();

        //    using (conn)
        //    {
        //        //Creamos un commando para realizar el select
        //        MySqlCommand command = new MySqlCommand();
        //        using (command)
        //        {
        //            //asignamos la conexion de trabajo
        //            command.Connection = conn;
        //            command.CommandType = CommandType.Text;

        //            //QUERY
        //            StringBuilder sblSQL = new StringBuilder();
        //            sblSQL.Append("SELECT z.ID, z.Nombre, z.Descripcion, z.Estado ");
        //            sblSQL.Append("FROM PR_ZonasProductos z ");
        //            sblSQL.Append("WHERE 1=1 ");
        //            if (SoloActivos)
        //            {
        //                sblSQL.Append(" AND z.Estado = 'ACT' ");
        //            }
        //            sblSQL.Append("ORDER BY z.ID ");
        //            command.CommandText = sblSQL.ToString();

        //            //el datareader me permite cargar un datatable o un dataset desde un origen de datos. Esto mediante el método Load del dt/ds. !!!
        //            MySqlDataReader myDR = command.ExecuteReader();

        //            //creo un datatable
        //            DataTable dtDatos = new DataTable();
        //            //cargo los datos en el datatable con el datareader 
        //            dtDatos.Load(myDR);

        //            //Cargo la lista
        //            List<ProductZone> lst = new List<ProductZone>();

        //            if (dtDatos.Rows.Count > 0)
        //            {
        //                for (int i = 0; i < dtDatos.Rows.Count; i++)
        //                {
        //                    DataRow row = dtDatos.Rows[i];

        //                    //Creo y cargo el obj
        //                    ProductZone obj = new ProductZone();
        //                    obj.ID = Convert.ToInt32(row["ID"]);
        //                    obj.Name = Convert.ToString(row["Nombre"]);
        //                    obj.Description = Convert.ToString(row["Descripcion"]);
        //                    obj.State = Convert.ToString(row["Estado"]);

                           
        //                    //agrego a la colección
        //                    lst.Add(obj);
        //                }
        //            }

        //            //devuelvo la colección
        //            return lst;
        //        }
        //    }

        //}

        //public ProductZone getProductZone(int ID)
        //{
        //    //conexion a la base de datos
        //    MySqlConnection conn = Configuracion.CrearConexionBD();
        //    conn.Open();

        //    using (conn)
        //    {
        //        //Creamos un commando para realizar el select
        //        MySqlCommand command = new MySqlCommand();
        //        using (command)
        //        {
        //            //asignamos la conexion de trabajo
        //            command.Connection = conn;
        //            command.CommandType = CommandType.Text;

        //            //QUERY
        //            StringBuilder sblSQL = new StringBuilder();
        //            sblSQL.Append("SELECT z.ID, z.Nombre, z.Descripcion, z.Estado ");
        //            sblSQL.Append("FROM PR_ZonasProductos z ");
        //            sblSQL.Append("WHERE z.ID = @ID ");
        //            command.CommandText = sblSQL.ToString();
                   
        //            //params
        //            command.Parameters.AddWithValue("@ID", ID);

        //            //el datareader me permite cargar un datatable o un dataset desde un origen de datos. Esto mediante el método Load del dt/ds. !!!
        //            MySqlDataReader myDR = command.ExecuteReader();
                                      

        //            //creo un datatable
        //            DataTable dtDatos = new DataTable();
        //            //cargo los datos en el datatable con el datareader 
        //            dtDatos.Load(myDR);
        //            if (dtDatos.Rows.Count > 0)
        //            {
        //                DataRow row = dtDatos.Rows[0];

        //                //Creo y cargo el obj
        //                ProductZone obj = new ProductZone();
        //                obj.ID = Convert.ToInt32(row["ID"]);
        //                obj.Name = Convert.ToString(row["Nombre"]);
        //                obj.Description = Convert.ToString(row["Description"]);
        //                obj.State = Convert.ToString(row["Estado"]);                                          

        //                //devuelvo el obj
        //                return obj;
        //            }

        //            //no existe el id
        //            return null;
        //        }
        //    }
        //}
        //#endregion

        //#region ProductType
        //public List<ProductType> getProductTypes(bool SoloActivos)
        //{
        //    //conexion a la base de datos
        //    MySqlConnection conn = Configuracion.CrearConexionBD();
        //    conn.Open();

        //    using (conn)
        //    {
        //        //Creamos un commando para realizar el select
        //        MySqlCommand command = new MySqlCommand();
        //        using (command)
        //        {
        //            //asignamos la conexion de trabajo
        //            command.Connection = conn;
        //            command.CommandType = CommandType.Text;

        //            //QUERY
        //            StringBuilder sblSQL = new StringBuilder();
        //            sblSQL.Append("SELECT t.ID, t.Nombre, t.Estado ");
        //            sblSQL.Append("FROM PR_TiposProductos t ");
        //            sblSQL.Append("WHERE 1=1 ");
        //            if (SoloActivos)
        //            {
        //                sblSQL.Append(" AND t.Estado = 'ACT' ");
        //            }
        //            sblSQL.Append("ORDER BY t.ID ");
        //            command.CommandText = sblSQL.ToString();

        //            //el datareader me permite cargar un datatable o un dataset desde un origen de datos. Esto mediante el método Load del dt/ds. !!!
        //            MySqlDataReader myDR = command.ExecuteReader();

        //            //creo un datatable
        //            DataTable dtDatos = new DataTable();
        //            //cargo los datos en el datatable con el datareader 
        //            dtDatos.Load(myDR);

        //            //Cargo la lista
        //            List<ProductType> lst = new List<ProductType>();

        //            if (dtDatos.Rows.Count > 0)
        //            {
        //                for (int i = 0; i < dtDatos.Rows.Count; i++)
        //                {
        //                    DataRow row = dtDatos.Rows[i];

        //                    //Creo y cargo el obj
        //                    ProductType obj = new ProductType();
        //                    obj.ID = Convert.ToInt32(row["ID"]);
        //                    obj.Name = Convert.ToString(row["Nombre"]);
        //                    obj.State = Convert.ToString(row["Estado"]);


        //                    //agrego a la colección
        //                    lst.Add(obj);
        //                }
        //            }

        //            //devuelvo la colección
        //            return lst;
        //        }
        //    }

        //}

        //public ProductType getProductType(int ID)
        //{
        //    //conexion a la base de datos
        //    MySqlConnection conn = Configuracion.CrearConexionBD();
        //    conn.Open();

        //    using (conn)
        //    {
        //        //Creamos un commando para realizar el select
        //        MySqlCommand command = new MySqlCommand();
        //        using (command)
        //        {
        //            //asignamos la conexion de trabajo
        //            command.Connection = conn;
        //            command.CommandType = CommandType.Text;

        //            //QUERY
        //            StringBuilder sblSQL = new StringBuilder();
        //            sblSQL.Append("SELECT t.ID, t.Nombre, t.Estado ");
        //            sblSQL.Append("FROM PR_TiposProductos t ");
        //            sblSQL.Append("WHERE t.ID = @ID ");                    
        //            command.CommandText = sblSQL.ToString();

        //            //params
        //            command.Parameters.AddWithValue("@ID", ID);

        //            //el datareader me permite cargar un datatable o un dataset desde un origen de datos. Esto mediante el método Load del dt/ds. !!!
        //            MySqlDataReader myDR = command.ExecuteReader();


        //            //creo un datatable
        //            DataTable dtDatos = new DataTable();
        //            //cargo los datos en el datatable con el datareader 
        //            dtDatos.Load(myDR);
        //            if (dtDatos.Rows.Count > 0)
        //            {
        //                DataRow row = dtDatos.Rows[0];

        //                //Creo y cargo el obj
        //                ProductType obj = new ProductType();
        //                obj.ID = Convert.ToInt32(row["ID"]);
        //                obj.Name = Convert.ToString(row["Nombre"]);
        //                obj.State = Convert.ToString(row["Estado"]);

        //                //devuelvo el obj
        //                return obj;
        //            }

        //            //no existe el id
        //            return null;
        //        }
        //    }
        //}
        //#endregion
        
        //#region Products
        //public List<Product> getProducts(bool SoloActivos, int IDTipoProducto, int IDZonaProducto, int CantRegistros)
        //{
        //    //conexion a la base de datos
        //    MySqlConnection conn = Configuracion.CrearConexionBD();
        //    conn.Open();

        //    using (conn)
        //    {
        //        //Creamos un commando para realizar el select
        //        MySqlCommand command = new MySqlCommand();
        //        using (command)
        //        {
        //            //asignamos la conexion de trabajo
        //            command.Connection = conn;
        //            command.CommandType = CommandType.Text;

        //            //QUERY
        //            StringBuilder sblSQL = new StringBuilder();
        //            sblSQL.Append("SELECT ");
        //            if (CantRegistros > 0)
        //            {
        //                sblSQL.Append("TOP @CantReg ");
        //                command.Parameters.AddWithValue("@CantReg", CantRegistros);
        //            }
        //            sblSQL.Append(" p.ID, p.Nombre, p.Descripcion, p.Estado, p.Precio, p.IDTipoProducto, p.IDZonaProducto, p.urlIMG, p.Orden ");
        //            sblSQL.Append(", t.Nombre as NombreTipoProducto ");
        //            sblSQL.Append(", z.Nombre as NombreZonaProducto ");
        //            sblSQL.Append(" FROM PR_Productos p ");
        //            sblSQL.Append(" INNER JOIN PR_TiposProductos t ON t.ID = p.IDTipoProducto ");
        //            sblSQL.Append(" INNER JOIN PR_ZonasProductos z ON z.ID = p.IDZonaProducto ");
        //            sblSQL.Append(" WHERE 1=1 ");
        //            if (SoloActivos)
        //            {
        //                sblSQL.Append(" AND p.Estado = 'ACT' ");
        //                sblSQL.Append(" AND t.Estado = 'ACT' ");
        //                sblSQL.Append(" AND z.Estado = 'ACT' ");
        //            }
        //            if (IDTipoProducto > 0)
        //            {
        //                sblSQL.Append(" AND p.IDTipoProducto = @IDTipoProducto ");
        //                command.Parameters.AddWithValue("@IDTipoProducto", IDTipoProducto);
        //            }
        //            if (IDZonaProducto > 0)
        //            {
        //                sblSQL.Append(" AND p.IDZonaProducto = @IDZonaProducto ");
        //                command.Parameters.AddWithValue("@IDZonaProducto", IDZonaProducto);
        //            }
        //            sblSQL.Append(" ORDER BY p.Orden ");
        //            command.CommandText = sblSQL.ToString();

        //            //el datareader me permite cargar un datatable o un dataset desde un origen de datos. Esto mediante el método Load del dt/ds. !!!
        //            MySqlDataReader myDR = command.ExecuteReader();

        //            //creo un datatable
        //            DataTable dtDatos = new DataTable();
        //            //cargo los datos en el datatable con el datareader 
        //            dtDatos.Load(myDR);

        //            //Cargo la lista
        //            List<Product> lst = new List<Product>();

        //            if (dtDatos.Rows.Count > 0)
        //            {
        //                for (int i = 0; i < dtDatos.Rows.Count; i++)
        //                {
        //                    DataRow row = dtDatos.Rows[i];

        //                    //Creo y cargo el obj
        //                    Product obj = new Product();
        //                    obj.ID = Convert.ToInt32(row["ID"]);
        //                    obj.Name = Convert.ToString(row["Nombre"]);
        //                    obj.Description = Convert.ToString(row["Descripcion"]);
        //                    obj.State = Convert.ToString(row["Estado"]);
        //                    obj.Order = Convert.ToInt32(row["Orden"]);
        //                    obj.ImagesURL = Convert.ToString(row["urlIMG"]);

        //                    ProductType objT = new ProductType();
        //                    objT.ID = Convert.ToInt32(row["IDTipoProducto"]);
        //                    objT.Name = Convert.ToString(row["NombreTipoProducto"]);
        //                    obj.Type  = objT;
        //                    //obj.Type = this.getProductType(Convert.ToInt32(row["IDTipoProducto"]));

        //                    ProductZone objZ = new ProductZone();
        //                    objZ.ID = Convert.ToInt32(row["IDZonaProducto"]);
        //                    objZ.Name = Convert.ToString(row["NombreZonaProducto"]);
        //                    obj.Zone = objZ;
        //                    //obj.Zone = this.getProductZone(Convert.ToInt32(row["IDZonaProducto"]));

        //                    //agrego a la colección
        //                    lst.Add(obj);
        //                }
        //            }

        //            //devuelvo la colección
        //            return lst;
        //        }
        //    }

        //}

        //public Product getProduct(int ID)
        //{
        //    //conexion a la base de datos
        //    MySqlConnection conn = Configuracion.CrearConexionBD();
        //    conn.Open();

        //    using (conn)
        //    {
        //        //Creamos un commando para realizar el select
        //        MySqlCommand command = new MySqlCommand();
        //        using (command)
        //        {
        //            //asignamos la conexion de trabajo
        //            command.Connection = conn;
        //            command.CommandType = CommandType.Text;

        //            //QUERY
        //            StringBuilder sblSQL = new StringBuilder();
        //            sblSQL.Append("SELECT p.ID, p.Nombre, p.Descripcion, p.Estado, p.Precio, p.IDTipoProducto, p.IDZonaProducto, p.urlIMG, p.Orden ");
        //            sblSQL.Append(", t.Nombre as NombreTipoProducto ");
        //            sblSQL.Append(", z.Nombre as NombreZonaProducto ");
        //            sblSQL.Append(" FROM PR_Productos p ");
        //            sblSQL.Append(" INNER JOIN PR_TiposProductos t ON t.ID = p.IDTipoProducto ");
        //            sblSQL.Append(" INNER JOIN PR_ZonasProductos z ON z.ID = p.IDZonaProducto ");
        //            sblSQL.Append(" WHERE 1=1 ");
        //            sblSQL.Append(" AND p.ID = @ID ");
        //            sblSQL.Append("ORDER BY p.ID ");
        //            command.CommandText = sblSQL.ToString();
                   
        //            //params
        //            command.Parameters.AddWithValue("@ID", ID);

        //            //el datareader me permite cargar un datatable o un dataset desde un origen de datos. Esto mediante el método Load del dt/ds. !!!
        //            MySqlDataReader myDR = command.ExecuteReader();
                              
        //            //creo un datatable
        //            DataTable dtDatos = new DataTable();
        //            //cargo los datos en el datatable con el datareader 
        //            dtDatos.Load(myDR);
        //            if (dtDatos.Rows.Count > 0)
        //            {
        //                DataRow row = dtDatos.Rows[0];

        //                //Creo y cargo el obj
        //                Product obj = new Product();
        //                obj.ID = Convert.ToInt32(row["ID"]);
        //                obj.Name = Convert.ToString(row["Nombre"]);
        //                obj.Description = Convert.ToString(row["Descripcion"]);
        //                obj.State = Convert.ToString(row["Estado"]);
        //                obj.Order = Convert.ToInt32(row["Orden"]);
        //                obj.ImagesURL = Convert.ToString(row["urlIMG"]);
        //                obj.Price = Convert.ToDecimal(row["Precio"]);

        //                ProductType objT = new ProductType();
        //                objT.ID = Convert.ToInt32(row["IDTipoProducto"]);
        //                objT.Name = Convert.ToString(row["NombreTipoProducto"]);
        //                obj.Type = objT;
        //                //obj.Type = this.getProductType(Convert.ToInt32(row["IDTipoProducto"]));

        //                ProductZone objZ = new ProductZone();
        //                objZ.ID = Convert.ToInt32(row["IDZonaProducto"]);
        //                objZ.Name = Convert.ToString(row["NombreZonaProducto"]);
        //                obj.Zone = objZ;
        //                //obj.Zone = this.getProductZone(Convert.ToInt32(row["IDZonaProducto"]));                                         

        //                //devuelvo el obj
        //                return obj;
        //            }

        //            //no existe el id
        //            return null;
        //        }
        //    }
        //}
        //#endregion
    }
}
