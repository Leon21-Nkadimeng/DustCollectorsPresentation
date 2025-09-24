using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class genderForm : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] != null && Session["UserType"].ToString().Equals("admin"))
            {
                if (Request.QueryString["genderId"] != null)
                {
                    try
                    {
                        if (!IsPostBack)
                        {
                            var gender = client.getGenderCategory(int.Parse(Request.QueryString["genderId"].ToString()));
                            if (gender != null)
                            {
                                txtName.Text = gender.name;
                                TextBox1.Text = gender.ageGroup;
                                isAvailable.Checked = gender.isActive;
                                title.InnerText = "Gender category id: " + gender.Id.ToString();
                            }
                            else
                            {
                                title.InnerText = "New Gender category id";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        title.InnerText = "New age-Gender category";
                    }
                }
                else
                {
                    title.InnerText = "New age-Gender category";
                }
            } else
            {
                Response.Redirect("accountDashboard.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (client.InsertGender(new GenderDTO() { name = txtName.Text, ageGroup = TextBox1.Text, isActive = isAvailable.Checked}))
            {
                Label1.Text = "New gender-age group category added successfully";
            } else
            {
                Label1.Text = "Gender-age group Category already exists";
            }

        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (client.updateGenderCategory(new GenderDTO() { name = txtName.Text, ageGroup = TextBox1.Text, isActive = isAvailable.Checked }))
            {
                Label1.Text = "Gender-age group category updated successfully";
            } else
            {
                Label1.Text = "Could not update gender-age group category";
            }
        }
    }
}