using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class colourways : System.Web.UI.Page
    {
        private Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null || !Session["UserType"].Equals("admin"))
                Response.Redirect("index.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (client.InsertProductColourway(new ColourwayDTO() { isActive = true, name = txtName.Text }))
                lblstatus.Text = "Colourway inserted successfully";
            else
                lblstatus.Text = "could not insert colourway";
        
        }
    }
}