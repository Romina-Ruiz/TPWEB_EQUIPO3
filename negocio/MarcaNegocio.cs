using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();


            try
            {


                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.CodMarca = (int)datos.Lector["Id"];
                    aux.NombreMarca = (string)datos.Lector["Descripcion"];

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


        public void Agregar(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT into MARCAS (Descripcion) values ('" + nuevo.NombreMarca+ "')");
                datos.ejecutarAccion();

                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { datos.cerrarConexion();}

        }

       
        public void Modificar(Marca seleccionado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update MARCAS set Descripcion=@descrip where Id=@id");
                datos.setearParametro("@descrip ", seleccionado.NombreMarca);
                datos.setearParametro("@id", seleccionado.CodMarca);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { datos.cerrarConexion(); }

        }


        public void Eliminar(int id)
        {
           
            try
            {

                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("Delete from MARCAS where Id=@Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    
    
    }
}

