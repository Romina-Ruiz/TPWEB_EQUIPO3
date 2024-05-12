using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria>listaCategorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id,Descripcion from CATEGORIAS");
                datos.ejecutarLectura();
                
                while(datos.Lector.Read())
                {
                    Categoria aux= new Categoria();
                    aux.Id= (int)datos.Lector["Id"];
                    aux.Descripcion= (string)datos.Lector["Descripcion"];
                    listaCategorias.Add(aux);

                }

                return listaCategorias;
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
        public void agregar(Categoria nueva)
        {
            AccesoDatos datos= new AccesoDatos();
            string patron = @"^[a-zA-Z\s]+$";
            string descripcion=nueva.Descripcion;
            try
            {
                if (Regex.IsMatch(descripcion, patron))
                {
                    datos.setearConsulta("Insert into CATEGORIAS(Descripcion)values('" + nueva.Descripcion + "')");
                datos.ejecutarAccion();

                }
                
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }

        }
        public void Modificar(Categoria catModificada)
        {AccesoDatos datos = new AccesoDatos();
            string patron = @"^[a-zA-Z\s]+$";
            string descripcion = catModificada.Descripcion;
            try
            {
                if (Regex.IsMatch(descripcion, patron))
                {
                    datos.setearConsulta("update CATEGORIAS set Descripcion= @desc Where Id= @id");
                datos.setearParametro("@desc", catModificada.Descripcion);
                datos.setearParametro("@id", catModificada.Id);

                datos.ejecutarAccion();

                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { 
            
                datos.cerrarConexion() ;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from CATEGORIAS Where Id = @id");
                datos.setearParametro("@id",id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
           

        }
    }
}
