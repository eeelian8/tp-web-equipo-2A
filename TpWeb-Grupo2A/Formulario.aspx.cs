using Dominio;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpWeb_Grupo2A
{
    public partial class Formulario : System.Web.UI.Page
    {
        string codVoucher {  get; set; }
        string idArticuloElegido { get; set; }

        List<Voucher> listaVoucher = new List<Voucher>();

        List<Cliente> listaCliente = new List<Cliente>();

        protected void Page_Load(object sender, EventArgs e)
        {
            codVoucher = Request.QueryString["cv"];
            idArticuloElegido = Request.QueryString["art"];

            ClienteCBD clienteCBD = new ClienteCBD();
            VoucherCBD voucherCBD = new VoucherCBD();

            listaVoucher = voucherCBD.Listar();
            listaCliente = clienteCBD.Listar();
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            Voucher aux = new Voucher();
            Cliente auxCliente = new Cliente();
            VoucherCBD auxCBD = new VoucherCBD();
            ClienteCBD auxClienteCBD = new ClienteCBD();

            auxCliente = listaCliente.Find(x => x.Documento == input_documento.Text);
            if (auxCliente != null)
            {
                aux.FechaCanje = DateTime.Now;
                aux.CodigoVoucher = codVoucher;
                aux.IdCliente = auxCliente.id;
                aux.IdArticulo = int.Parse(idArticuloElegido);
                auxCBD.Modificar(aux);
                Response.Redirect("Final.aspx", false);
                return;
            }
            else
            {
                auxCliente.Nombre = input_nombre.Text;
                auxCliente.Apellido = input_apellido.Text;
                auxCliente.Email = input_email.Text;
                auxCliente.Direccion = input_direccion.Text;
                auxCliente.Documento = input_documento.Text;
                auxCliente.Ciudad = input_ciudad.Text;
                auxCliente.Cp = input_codigoPostal.Text;
                auxClienteCBD.Agregar(auxCliente);
            }

            listaCliente.Clear();

            ClienteCBD listaActualizada = new ClienteCBD();
            listaCliente = listaActualizada.Listar();
            auxCliente = listaCliente.Find(x => x.Documento == input_documento.Text);
            aux.FechaCanje = DateTime.Now;
            aux.CodigoVoucher = codVoucher;
            aux.IdCliente = auxCliente.id;
            aux.IdArticulo = int.Parse(idArticuloElegido);
            auxCBD.Modificar(aux);
            Response.Redirect("Final.aspx", false);
            return;
        }
    }
}