using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
using System.ComponentModel.DataAnnotations;


namespace TPWEB_EQUIPO3
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos;
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
                    rpArticulo.DataSource =lista;
                    rpArticulo.DataBind();
                }

            }

            }
            
           
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            /* string nombre=((Button)sender).CommandArgument;


            Articulo art= new Articulo();



             List<Articulo> Temporal = (List<Articulo>)Session["listacarrito"];
             Temporal.Add(art);

             Response.Redirect("CARRITO.aspx");*/

        }
    }
}