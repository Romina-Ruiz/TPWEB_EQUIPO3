using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWEB_EQUIPO3
{
    public partial class CARRITO : System.Web.UI.Page
    {
                          

        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            List<Articulo> listaOriginal = negocio.listar();

            List<Articulo> listacarrito;
           
            listacarrito = Session["listacarrito"] != null ? (List<Articulo>)Session["listacarrito"] : new List<Articulo>();
            
            Session.Add("listacarrito", listacarrito);

                       
            int id = int.Parse(Request.QueryString["id"]);
         
            
                Articulo seleccionado = listaOriginal.Find(x => x.Id == id);
                listacarrito.Add(seleccionado);

                dgvCarrito.DataSource = listacarrito;
                dgvCarrito.DataBind();

                  
            

        }

        protected void dgvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            int id =int.Parse(dgvCarrito.SelectedDataKey.Value.ToString());

          
            List<Articulo> temporal = (List<Articulo>)Session["listacarrito"];
           
            Articulo seleccionado= temporal.Find(x => x.Id == id);
            temporal.Remove(seleccionado);
            Session["listacarrito"]= temporal;

          // dgvCarrito.DataSource = Session["listacarrito"];
          // dgvCarrito.DataBind();
            */

        }
    }
   
}