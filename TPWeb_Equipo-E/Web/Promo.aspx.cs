using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Web
{
    public partial class Promo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnSiguiente_Click(object sender, EventArgs e)
        {
            string codigoIng = TBoVoucher.Text.Trim();

            var negocio = new Negocio.VoucherNegocio();

            bool voucherValido = negocio.VerificarVoucher(codigoIng);

            if (voucherValido)
            {
                negocio.AsignarVoucher(codigoIng);
                Response.Redirect("PromoDos.aspx", false);
            }
            else
            {
                string script = "alert('El Codigo ya fue canjeado o no es uno Valido!');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

            }
            
            

        }
    }
}