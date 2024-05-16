using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWEB_EQUIPO3
{
    public partial class CARRITO : System.Web.UI.Page
    {
       

        public List<Articulo> ListaArticulos;
        public List<Articulo> ListaCarrito;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                ArticuloNegocio negocio = new ArticuloNegocio();

                ListaArticulos = negocio.listar();
                foreach (Articulo arti in ListaArticulos)
                {
                    if (arti.Id == id)
                    {
                        List<Articulo> lista = new List<Articulo>();
                        lista.Add(arti);
                        
                       
                        dgbCarrito.DataSource=lista;
                        dgbCarrito.DataBind();
                    }

                }

            }

        }

          
        

    }
   
}