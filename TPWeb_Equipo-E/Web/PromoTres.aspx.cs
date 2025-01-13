using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Negocio;

namespace Web
{
    public partial class PromoTres : System.Web.UI.Page
    {
        string codigo;
        int idCliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            codigo = Session["codigo"] != null ? Session["codigo"].ToString() : "";
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente
            {
                Documento = TboDocumento.Text.Trim(),
                Nombre = TboNombre.Text.Trim(),
                Apellido = TboApellido.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Direccion = TboDireccion.Text.Trim(),
                Ciudad = TboCiudad.Text.Trim(),
                Cp = int.Parse(TboCp.Text.Trim())
            };

            ClienteNegocio clienteNegocio = new ClienteNegocio();

            try
            { 
                idCliente = clienteNegocio.CrearCliente(nuevoCliente);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                clienteNegocio.AsignarCliente(idCliente, codigo);

                string script = "alert('¡Felicidades ya estas participando por el premio!');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                Response.Redirect("Default.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}