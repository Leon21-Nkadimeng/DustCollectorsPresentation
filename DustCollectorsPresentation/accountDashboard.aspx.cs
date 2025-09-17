using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DustCollectorsPresentation
{
    public partial class accountDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionID"] != null && Session["UserID"] != null && Session["Username"] != null && Session["UserType"] != null)
            {

            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}