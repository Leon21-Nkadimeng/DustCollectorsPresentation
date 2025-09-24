using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class addCategory : System.Web.UI.Page
    {
        private Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null || !Session["UserType"].Equals("admin"))
                Response.Redirect("index.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (client.InsertProductCategory(new CategoryDTO() { name = txtName.Text, isAvailable = isAvailable.Checked}))
            {
                Label1.Text = "Category added successfully";
            } else
            {
                Label1.Text = "Could not add category";
            }
        }
    }
}