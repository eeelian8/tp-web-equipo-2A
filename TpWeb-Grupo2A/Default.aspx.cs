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
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void input_codigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btn_codigo_Click(object sender, EventArgs e)
        {
            string text = input_codigo.Text;
            Response.Redirect("Premios.aspx", false);   
        }
    }
}