using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
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
        public string codVaucher { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void input_codigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btn_codigo_Click(object sender, EventArgs e)
        {

            string text = input_codigoVoucher.Text;

            if (string.IsNullOrEmpty(text) || text == "0")
            {
                alertMessage.Text = "<div class=\"alert alert-warning\" role=\"alert\">\r\n  Para continuar debe ingresar un codigo!! \r\n</div>";
                return;
            }

            VoucherCBD voucherCBD = new VoucherCBD();
            List<Voucher> voucherList = voucherCBD.Listar();
            Voucher aux = new Voucher();

            try
            {
                aux = voucherList.Find(x => x.CodigoVoucher == text);
                if (aux != null)
                {
                    codVaucher = text;
                    Response.Redirect("Premios.aspx", false);
                } else
                {
                    alertMessage.Text = "<div class=\"alert alert-danger\" role=\"alert\">\r\n  El codigo ingresado es invalido o ya fue utilizado!! \r\n</div>";
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}