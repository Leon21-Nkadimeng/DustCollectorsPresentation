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
    public partial class addAdmin : System.Web.UI.Page
    {
        private Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null || !Session["UserType"].Equals("admin"))
                Response.Redirect("index.aspx");
            if (!IsPostBack)
            {
                breadCrumb.InnerHtml += "<span class='stext-109 cl4'>";
                breadCrumb.InnerHtml += "Brand Form";
                breadCrumb.InnerHtml += "</span>";
            }
        }

        protected void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (!InputValidator.isValidPhoneNumber(txtPhoneNumber.Text.Trim()))
            {
                lblStatus.Text = "Invalid South African Phone Number";
            }
            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                lblStatus.Text = "Cannot Register Account: Passwords do not match";
            }
            else
            {
                var newAdmin = new SysUser()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    EmailAddress = txtEmailAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    Password = Secrecy.HashPassword(txtPassword.Text),
                    UserType = "admin"
                };
                if(client.IsReg(newAdmin))
                {
                    lblStatus.Text = "Admin added successfully";
                } else
                {
                    lblStatus.Text = "Could not add admin";
                }
            }
        }
    }
}