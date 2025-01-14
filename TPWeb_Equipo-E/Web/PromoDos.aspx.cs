using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using Negocio;
using Modelo;

namespace Web
{
    public partial class PromoDos : Page
    {
        
        public List<Articulo> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();
            ListaArticulo = Negocio.listarConSP();

            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulo;
                repRepetidor.DataBind();
            }    

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("PromoTres.aspx");//redirecciona

        }
    }
}