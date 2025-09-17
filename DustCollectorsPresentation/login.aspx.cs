using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class login : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            btnToRegister.CausesValidation = false;
            btnToRegister.UseSubmitBehavior = false;

            if(Request.QueryString["registerStatus"] != null)
            {
                login_title.InnerText = "Login To Your Newly Created Account";
            }


        }

        protected void btnToRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(!InputValidator.isValidEmail(txtEmail.Text.Trim()))
            {
                lblLoginStatus.Text = "Invalid Email Address";
            } 
            else
            {
                UserSessionDetails sessionDetails = client.GetUserSessionDetails(txtEmail.Text, HashPass.Secrecy.HashPassword(txtPassword.Text));
                if(sessionDetails != null)
                {
                    Session["SessionID"] = Session.SessionID;
                    Session["UserID"] = sessionDetails.Id;
                    Session["Username"] = sessionDetails.Name;
                    Session["UserType"] = sessionDetails.userType;
                    Response.Redirect("index.aspx");
                } else
                {
                    lblLoginStatus.Text = "Could not find account";
                }
            }
        }
    }
}