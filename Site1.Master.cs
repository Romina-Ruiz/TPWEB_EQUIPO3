using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWEB_EQUIPO3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Inicializar el carrito de compras si es la primera carga de la página
                List<CartItem> cartItems = Session["CartItems"] as List<CartItem>;
                if (cartItems == null)
                {
                    cartItems = new List<CartItem>();
                    Session["CartItems"] = cartItems;
                }

                BindCart();
            }
        }

        protected void BindCart()
        {
            List<CartItem> cartItems = Session["CartItems"] as List<CartItem>;
            if (cartItems != null)
            {
                rptCartItems.DataSource = cartItems;
                rptCartItems.DataBind();

                decimal total = cartItems.Sum(item => item.Price * item.Quantity);
                litTotal.Text = total.ToString("0.00");
            }
        }
    }

    public class CartItem
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    
}
    }
