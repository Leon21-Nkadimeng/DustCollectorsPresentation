using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
using HashPass;
namespace DustCollectorsPresentation
{
    public partial class securityDetails : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionID"] != null && Session["UserID"] != null && Session["Username"] != null && Session["UserType"] != null)
            {
            }
            else
            {
                Response.Redirect("accountDashboard.aspx");
            }
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string password = client.GetUserPassword(int.Parse(Session["UserID"].ToString()));
                if(Secrecy.HashPassword(txtCurrentPassword.Text).Equals(password))
                {
                    if (txtCurrentPassword.Text.Equals(txtConfirmNewPassword.Text))
                    { 

                    } else {
                        lblStatus.Text = "New Passwords do not match";
                    }
                } else
                {
                    lblStatus.Text = "Incorrect current password";
                }
            } catch(FormatException ex)
            {

            } 
        }
    }
}