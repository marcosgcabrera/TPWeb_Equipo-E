using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelo;

namespace Negocio
{
    public class ClienteNegocio
    {
        public int CrearCliente(Cliente nuevoCliente)
        {
            int idCliente = 0;
            AccesoDatos datos = new AccesoDatos();
    
            try
            {
                datos.setearConsulta("INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP)OUTPUT INSERTED.Id VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP);");
                datos.setearParametro("@Documento", nuevoCliente.Documento);
                datos.setearParametro("@Nombre", nuevoCliente.Nombre);
                datos.setearParametro("@Apellido", nuevoCliente.Apellido);
                datos.setearParametro("@Email", nuevoCliente.Email);
                datos.setearParametro("@Direccion", nuevoCliente.Direccion);
                datos.setearParametro("@Ciudad", nuevoCliente.Ciudad);
                datos.setearParametro("@CP", nuevoCliente.Cp);
                datos.ejecutarAccion();

                datos.getearConsulta();

                if (datos.Lector != null && datos.Lector.HasRows)
                {
                    
                    if (datos.Lector.Read())
                    {
                        idCliente = Convert.ToInt32(datos.Lector[0]); // tomamos el valor del de la primer fila que seria el id
                        nuevoCliente.Id = idCliente;
                    }
                    else
                    {
                       
                        throw new Exception("No se pudo obtener el Id generado del lector.");
                    }
                }
                else
                {
                    
                    throw new Exception("No se obtuvo ningún dato del lector, la consulta no generó un Id.");
                }
            }
            catch (Exception ex)
            {
                
                datos.cerrarConexion();
                throw new Exception("Error al crear el cliente: " + ex.Message);
            }

            return idCliente; // hace return del id del objeto creado
        }

        public void AsignarCliente(int Id, string codigo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE Vouchers SET IdCliente = @IdCliente WHERE CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@IdCliente", Id);
                datos.setearParametro("@CodigoVoucher", codigo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    }

