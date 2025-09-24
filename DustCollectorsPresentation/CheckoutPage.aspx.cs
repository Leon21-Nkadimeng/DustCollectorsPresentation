using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DustCollectorsPresentation
{
    public partial class CheckoutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Session["UserType"] == null || !Session["UserType"].Equals("customer"))
             //   Response.Redirect("index.aspx");
        }

        protected void displayInvoiceProducts()
        {

        }
    }
}