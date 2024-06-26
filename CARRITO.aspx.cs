﻿using dominio;
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

        public List<Articulo> listacarrito;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {




                ArticuloNegocio negocio = new ArticuloNegocio();

                List<Articulo> listaOriginal = negocio.listar();

                List<Articulo> listacarrito;


                listacarrito = Session["listacarrito"] != null ? (List<Articulo>)Session["listacarrito"] : new List<Articulo>();

                Session.Add("listacarrito", listacarrito);

                rpCarrito.DataSource = listacarrito;
                rpCarrito.DataBind();

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);



                    Articulo seleccionado = listaOriginal.Find(x => x.Id == id);
                    listacarrito.Add(seleccionado);


                    rpCarrito.DataSource = listacarrito;
                    rpCarrito.DataBind();



                }





            }













        }





        //protected void btEliminar_Click(object sender, EventArgs e)
        //{

        //    int aux = int.Parse(((Button)sender).CommandArgument);


        //    List<Articulo> temporal = (List<Articulo>)Session["listacarrito"];

        //    Articulo seleccionado = temporal.Find(x => x.Id == aux);
        //    temporal.Remove(seleccionado);
        //    Session["listacarrito"] = temporal;



        //    rpCarrito.DataSource = null;
        //    rpCarrito.DataSource = Session["listacarrito"];
        //    rpCarrito.DataBind();





        //}

        protected void btEliminar_Command(object sender, CommandEventArgs e)
        {
            if (IsPostBack)
            {
                int aux = int.Parse(e.CommandArgument.ToString());
                List<Articulo> temporal = Session["listacarrito"] as List<Articulo>;
                Articulo seleccionado = temporal.Find(x => x.Id == aux);
                temporal.Remove(seleccionado);
                Session["listaCarrito"] = temporal;

                rpCarrito.DataSource = Session["listacarrito"];
                rpCarrito.DataBind();

            }
        }
    }

}