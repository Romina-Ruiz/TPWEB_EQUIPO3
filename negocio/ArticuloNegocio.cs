using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace negocio



{
     public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();           

            try
            {                              
                    
                         
                datos.setearConsulta("select A.Id as IdArti, A.Codigo, A.Nombre," +
                    " A.Descripcion, A.Precio,A.IdMarca,C.Id, M.Descripcion" +
                    " as des_marca,C.Descripcion as des_Categoria," +
                    "I.Id as Id_img,I.IdArticulo, I.ImagenUrl" +
                    " from ARTICULOS A, MARCAS M , CATEGORIAS C ," +
                    " IMAGENES I where A.IdMarca = M.Id " +
                    "and A.IdCategoria = C.Id and I.IdArticulo = A.Id ");

                datos.ejecutarLectura();              
                           
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["IdArti"];

                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Codigo"))))
                    {
                        aux.Cod_Articulo = (string)datos.Lector["Codigo"];
                    }
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre"))))
                    {
                        aux.Nombre_Articulo = (string)datos.Lector["Nombre"];
                    }
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Descripcion"))))
                    {
                        aux._Descripcion = (string)datos.Lector["Descripcion"];
                    }
                    if (!(datos.Lector["Precio"] is DBNull))
                    {
                        decimal cantidad = (decimal)datos.Lector["Precio"];
                        aux.Precio = (float)cantidad;
                    }

                    aux.Id_marca = (int)datos.Lector["IdMarca"];
                    aux.Id_cate = (int)datos.Lector["Id"];


                    if (!(datos.Lector["des_marca"] is DBNull))
                    {
                        aux.des_marca = (string)datos.Lector["des_marca"];
                    }
                    if (!(datos.Lector["des_categoria"] is DBNull))
                    {
                        aux.des_categoria = (string)datos.Lector["des_categoria"];
                    }

                    //IMAGENES
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.urlImagen = (string)datos.Lector["ImagenUrl"];
                    }

                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];

                    aux.Id_imagen = (int)datos.Lector["Id_img"];

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

        public Articulo UltimoId()
        {
            Articulo ultimoArticulo = new Articulo();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select max(Id) as IdUltimo from ARTICULOS");
                datos.ejecutarLectura();

                datos.Lector.Read();
                
                ultimoArticulo.Id = (int)datos.Lector["IdUltimo"];
                

                return ultimoArticulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Agregar(Articulo Art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
             datos.setearConsulta("INSERT INTO Articulos (Codigo, Nombre, Descripcion," +
                                  "IdMarca,IdCategoria, Precio) " +
                                  "VALUES ('" + Art.Cod_Articulo + "','" + Art.Nombre_Articulo +"'" +
                                  ",'" + Art._Descripcion + "',"+ Art.Id_marca +"," +
                                  ""+ Art.Id_cate +","+ Art.Precio +")");                
                
             datos.ejecutarAccion();              

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                datos.cerrarConexion();
            }     
        
        }
        public void AgregarImagen(Articulo Art) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into imagenes values(" + Art.Id + ",'" + Art.urlImagen + "')");

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

        } 




        public void Modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
        
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = '" + modificar.Cod_Articulo + "" +
                                    "', Nombre = '" + modificar.Nombre_Articulo + "" +
                                    "', Descripcion = '" + modificar._Descripcion + "'" +
                                    ", IdMarca = " + modificar.Id_marca +"," +
                                    " IdCategoria = " + modificar.Id_cate + " ," +
                                    "Precio = " + modificar.Precio + "" +
                                    " where Id = "+ modificar.Id +"");

                datos.setearParametro("Codigo", modificar.Cod_Articulo);
                datos.setearParametro("Nombre", modificar.Nombre_Articulo);
                datos.setearParametro("Descripcion", modificar._Descripcion);               

                datos.setearParametro("Id", modificar.Id);
                datos.setearParametro("IdMarca", modificar.Id_marca);
                datos.setearParametro("IdCategoria", modificar.Id_cate);
                datos.setearParametro("Precio", modificar.Precio);

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
            
            try
            {
                datos.setearConsulta("update IMAGENES set IdArticulo = " + modificar.Id + ", ImagenUrl ='" + modificar.urlImagen + "' where IdArticulo = " + modificar.IdArticulo + "");

                datos.setearParametro("IdArticulo", modificar.Id);
                datos.setearParametro("UrlImagen", modificar.urlImagen);

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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = " + id + "");
                datos.setearParametro("Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
