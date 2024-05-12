using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;


namespace TPWEB_EQUIPO3
{
    public partial class CATEGORIAS : System.Web.UI.Page
    {

        public List<Categoria> ListaCategorias {  get; set; }   
        protected void Page_Load(object sender, EventArgs e)
        {

            CategoriaNegocio negocio = new CategoriaNegocio();

            ListaCategorias = negocio.listarconSP();

            repRepetidor.DataSource=ListaCategorias;
            repRepetidor.DataBind();


        }
    }
}