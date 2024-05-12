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
    public partial class MARCAS : System.Web.UI.Page
    {

        public List<Marca> ListaMarcas{ get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            MarcaNegocio  negocio1 = new MarcaNegocio();


            ListaMarcas = negocio1.listarSP();

           
            RepetidorMarcas.DataSource = ListaMarcas;
            RepetidorMarcas.DataBind(); 
            




        }
    }
}