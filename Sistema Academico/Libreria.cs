using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace empleado
{
    public class Libreria
    {
        public static DataSet consulta(string sql)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadenaConexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
        
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

         
        }
        public static int ejecuta(string sql)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadenaConexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadenaConexion); SqlCommand commando = new SqlCommand(sql, conexion);
            conexion.Open();
            int numeo_registro = commando.ExecuteNonQuery();
            conexion.Close();
            return numeo_registro;
        }
    }
}