using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web
{
    public class AccesoDatos
    {

        private SqlConnection conexion;//se encarga de obtener la direccion y conectar a la base de datos
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector //lee el lector desde el exterior
        {
            get { return lector; }
        }


        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS;Database=PROMOS_DB;Integrated Security=True;");
            comando = new SqlCommand(); //lo creamos aca para poder reutilizarlo en demas metodos
        }

        public void setearConsulta(string consulta)//Accedemos
        {
            comando.CommandType = System.Data.CommandType.Text;//indicamos el tipo de consulta
            comando.CommandText = consulta;//asignamos la consulta que se va a ejecutar

        }
        public void setearParametro(string nombre, string valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void getearConsulta()//realizar lectura y guarda en lector
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader(); //Ejecuta la consulta y guarda los resultados en 'lector'
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ejecutarAccion()//ejecuta consulta nonquery de insercion de datos
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}