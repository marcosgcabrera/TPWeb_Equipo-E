using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;
using Datos;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarConSP()
        
            
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT   id, Nombre,Codigo,Descripcion, Precio, IdMarca, IdCategoria from ARTICULOS IMAGENES";
                datos.setearConsulta(consulta);
                datos.getearConsulta();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Marca = new Marca();
                   

                    aux.Imagenes = new List<Imagen>();
                    Imagen imagen = new Imagen();
                    //if (!(datos.Lector["Imagen"] is DBNull))
                        //imagen.Url = (string)datos.Lector["Imagen"];
                    //aux.Imagenes.Add(imagen);

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}

