using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace TPWEB_EQUIPO3
{
    public partial class COMPRAR : System.Web.UI.Page
    {


        public List<Articulo> ListaArticulos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio=new ArticuloNegocio();

            ListaArticulos = negocio.listar();

           repArticulos.DataSource=ListaArticulos;
           repArticulos.DataBind();



        }

        protected void Unnamed_Click(object sender, EventArgs e )
        {
            Articulo articulo;
            Button btn = (Button)sender;
            int articuloID = Convert.ToInt32(btn.CommandArgument);
            foreach (Articulo item in ListaArticulos)
            {
                articulo = ListaArticulos[articuloID];
             
            }


        }

        }
    }
