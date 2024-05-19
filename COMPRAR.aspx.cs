using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace TPWEB_EQUIPO3
{
    public partial class COMPRAR : System.Web.UI.Page
    {

        public List<Articulo> ListaArticulos; //{ get; set; }

        protected void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            ListaArticulos = negocio.listar();

            if (!IsPostBack)
            {
                rpArticulos.DataSource = ListaArticulos;
                rpArticulos.DataBind();

            }
           



        }
        protected void Page_Load(object sender, EventArgs e)
        {
         

           cargar();      

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {                 
            cargar();          
           
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {

            List<Articulo> listafiltrada;

            string filtro = tbxbuscar.ToString();

            if (filtro.Length >= 3)
            {
                listafiltrada = ListaArticulos.FindAll(x => x.Nombre_Articulo.ToUpper().Contains(filtro.ToUpper()) || x.des_categoria.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {

                listafiltrada = ListaArticulos;

            }




            //rpArticulos.DataSource = null;
            rpArticulos.DataSource = listafiltrada;
            rpArticulos.DataBind();







        }
    }
 }
