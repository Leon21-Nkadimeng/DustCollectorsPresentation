using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
   
    public partial class personalDetails : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionID"] != null && Session["UserID"] != null && Session["Username"] != null && Session["UserType"] != null)
            {
                if (!IsPostBack)
                {
                    UserPersonalDetails user = null;
                    try
                    {
                        user = client.GetUserDetails(int.Parse(Session["UserID"].ToString()));
                        txtFirstName.Text = user.FirstName;
                        txtLastName.Text = user.LastName;
                        txtPhoneNumber.Text = user.PhoneNumber;
                        txtEmailAddress.Text = user.EmailAddress;
                    }
                    catch (FormatException ex1)
                    {
                        Response.Redirect("accountDashboard.aspx");
                    }
                    catch (NullReferenceException ex)
                    {
                        Response.Redirect("accountDashboard.aspx");
                    }
                }
                

            } else
            {
                Response.Redirect("accountDashboard.aspx");
            }
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UserPersonalDetails user = new UserPersonalDetails()
            {
                ID = int.Parse(Session["UserID"].ToString()),
                FirstName = txtFirstName.Text,
                LastName= txtLastName.Text,
                PhoneNumber= txtPhoneNumber.Text,
                EmailAddress = txtEmailAddress.Text
        };
            if (client.updateUserPersonalDetails(user))
            {
                Session["UserName"] = user.FirstName;
                lblStatus.Text = "Personal Details Successfully Updated";
            }
            else
                lblStatus.Text = "Could Not Update Personal Details";
        }
    }
}