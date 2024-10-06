using Data_Management;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class VoucherCBD
    {
        public List<Voucher> Listar()
        {
            List<Voucher> listaVoucher = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select CodigoVoucher, IdCliente, FechaCanje, IdArticulo from Vouchers ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Voucher aux = new Voucher();

                    aux.CodigoVoucher = datos.Lector.IsDBNull(0) ? "0" : (string)datos.Lector["CodigoVoucher"];
                    aux.IdCliente = datos.Lector.IsDBNull(1) ? 0 : (int)datos.Lector["IdCliente"];
                    aux.FechaCanje = datos.Lector.IsDBNull(2) ? new DateTime() : (DateTime)datos.Lector["FechaCanje"];
                    aux.IdArticulo = datos.Lector.IsDBNull(3) ? 0 : (int)datos.Lector["IdArticulo"];

                    listaVoucher.Add(aux);
                }

                return listaVoucher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(Voucher vou)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Vouchers set CodigoVoucher = @CodigoVoucher, @IdCliente = @IdCliente, IdArticulo = @IdArticulo, FechaCanje = @FechaCanje where CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@CodigoVoucher", vou.CodigoVoucher);
                datos.setearParametro("@IdCliente", vou.IdCliente);
                datos.setearParametro("@IdArticulo", vou.IdArticulo);
                datos.setearParametro("@FechaCanje", vou.FechaCanje);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(string codigoVoucher)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from Vouchers where CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@CodigoVoucher", codigoVoucher);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
