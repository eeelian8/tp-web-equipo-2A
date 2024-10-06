using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicios;

namespace TpWeb_Grupo2A
{
    
    public partial class Premios : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        public List<Imagen> ListaImagenes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloCBD articuloCBD = new ArticuloCBD();
            ListaArticulos = articuloCBD.Listar();
        }

        protected void btn_2doPremio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx", false);
        }

        protected void btn_1erPremio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx", false);
        }

        protected void btn_3erPremio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx", false);
        }
    }
}