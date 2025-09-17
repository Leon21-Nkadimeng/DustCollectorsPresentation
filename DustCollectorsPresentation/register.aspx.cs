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
    public partial class register : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (!InputValidator.isValidPhoneNumber(txtPhone.Text.Trim()))
            {
                lblRegisterStatus.Text = "Invalid South African Phone Number";
            }
            else if (!InputValidator.isValidEmail(txtEmail.Text.Trim()))
            {
                lblRegisterStatus.Text = "Invalid Email Address";
            }
            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                lblRegisterStatus.Text = "Cannot Register Account: Passwords do not match";
            }
            else
            {
                var newCustomer = new SysUser()
                {
                   FirstName = txtFirstName.Text,
                   LastName = txtLastName.Text,
                   EmailAddress = txtEmail.Text,
                   PhoneNumber = txtPhone.Text.Trim(),
                   Password = Secrecy.HashPassword(txtPassword.Text),
                   UserType = "customer"
                };
                

                if (client.IsReg(newCustomer))
                {
                    Response.Redirect("login.aspx?registerStatus=success");
                }
                else
                {
                    lblRegisterStatus.Text = "Error Could not register your account (try changing your email address)";
                }
            }
        }
    }
}