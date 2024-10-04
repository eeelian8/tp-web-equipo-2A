using Data_Management;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class VoucherCBD
    {
        public List<Voucher> Listar()
        {
            List<Voucher> lista = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select V.CodigoVoucher, V.IdCliente, V.FechaCanje, V.IdArticulo from Vouchers V");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Voucher aux = new Voucher();
                    aux.CodigoVoucher = (string)datos.Lector["CodigoVoucher"];
                    aux.IdCliente = (int)datos.Lector["IdCliente"];
                    aux.FechaCanje = (DateTime)datos.Lector["FechaCanje"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Agregar(Voucher vou)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into Vouchers(CodigoVoucher, IdCliente, IdArticulo, FechaCanje) Values(@CodigoVoucher, @IdCliente, @IdArticulo, @FechaCanje)");
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
