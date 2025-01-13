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
    public class VoucherNegocio
    {
        public bool VerificarVoucher(string codigoVoucher)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT CodigoVoucher, FechaCanje FROM Vouchers WHERE CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@CodigoVoucher", codigoVoucher);
                datos.getearConsulta();

                if (datos.Lector.Read())
                {
                    DateTime? fechaCanje = datos.Lector["FechaCanje"] as DateTime?;

                if (fechaCanje == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                }return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void AsignarVoucher(string codigoIng)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE Vouchers SET FechaCanje = CAST(GETDATE() AS DATE) WHERE CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@FechaCanje ", DateTime.Now);
                datos.setearParametro("@CodigoVoucher", codigoIng);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }

}
