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
            Response.Redirect("PromoDos.aspx", false);

            //string codigoIng = TboVoucher.Text.Trim();
            //if (codigoIng!=)
            {
                
            }

        }
    }
}