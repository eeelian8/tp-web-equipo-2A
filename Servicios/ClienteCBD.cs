using Data_Management;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ClienteCBD
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select C.Id, C.Documento, C.Nombre, C.Apellido, C.Email, C.Direccion, C.Ciudad, C.CP from Clientes C");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.id = (int)datos.Lector["Id"];
                    aux.Documento = (string)datos.Lector["Documento"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.Ciudad = (string)datos.Lector["Ciudad"];
                    aux.Cp = (string)datos.Lector["Cp"];

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

        public void Agregar(Cliente cli)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into Clientes(Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) Values(@Id, @Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.setearParametro("@Id", cli.id);
                datos.setearParametro("@Documento", cli.Documento);
                datos.setearParametro("@Nombre", cli.Nombre);
                datos.setearParametro("@Apellido", cli.Apellido);
                datos.setearParametro("@Email", cli.Email);
                datos.setearParametro("@Direccion", cli.Direccion);
                datos.setearParametro("@Ciudad", cli.Ciudad);
                datos.setearParametro("@CP", cli.Cp);
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

        public void Modificar(Cliente cli)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Clientes set Id = @Id, Documento = @Documento, Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Direccion = @Direccion, Ciudad = @Ciudad, CP = @CP where Documento = @Documento");
                datos.setearParametro("@Nombre", cli.Nombre);
                datos.setearParametro("@Apellido", cli.Apellido);
                datos.setearParametro("@Documento", cli.Documento);
                datos.setearParametro("@Email", cli.Email);
                datos.setearParametro("@Direccion", cli.Direccion);
                datos.setearParametro("@Ciudad", cli.Ciudad);
                datos.setearParametro("@CP", cli.Cp);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(string documento)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from Clientes where Documento = @Documento");
                datos.setearParametro("@Documento", documento);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Cliente Buscar(string documento)
        {
            ClienteCBD clienteCBD = new ClienteCBD();
            List<Cliente> ListaClientes = new List<Cliente>();
            ListaClientes = clienteCBD.Listar();

            try
            {
                foreach (Cliente cli in ListaClientes)
                {
                    if (cli.Documento == documento)
                    {
                        return cli;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
