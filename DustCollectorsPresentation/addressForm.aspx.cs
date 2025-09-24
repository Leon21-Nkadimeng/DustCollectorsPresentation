using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class addressForm : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] != null)
            {

                if (Request.QueryString["editingAddress"] != null && Request.QueryString["editingAddress"].Equals("true") && Request.QueryString["addressId"] != null)
                {
                    btnSaveChanges.Visible = true;
                    btnSubmit.Visible = false;
                    CustomerAddress address = client.getCustomerAddress(int.Parse(Request.QueryString["addressId"].ToString()));

                    if(address != null)
                    {
                        txtCityOrTown.Text = address.CityOrTown;
                        txtComplexOrBuilding.Text = address.ComplexOrBuilding;
                        txtPostalCode.Text = address.PostalCode;
                        txtRecipientName.Text = address.RecipientName;
                        txtStreetAddress.Text = address.StreetAddress;
                        txtSuburb.Text = address.Suburb;
                        provinceList.SelectedValue = address.Province;
                        txtRecipientPhone.Text = address.RecipientPhone;
                    }
                }
                else if (Request.QueryString["insertingAddress"] != null && Request.QueryString["insertingAddress"].Equals("true"))
                {
                    btnSaveChanges.Visible = false;
                    btnSubmit.Visible = true;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isInserted = client.InsertAddress(new CustomerAddress()
            {
                RecipientName = txtRecipientName.Text,
                RecipientPhone = txtRecipientPhone.Text,
                Suburb = txtSuburb.Text,
                CityOrTown = txtCityOrTown.Text,
                ComplexOrBuilding = txtComplexOrBuilding.Text,
                StreetAddress = txtStreetAddress.Text,
                PostalCode = txtPostalCode.Text,
                Province = provinceList.SelectedValue,
                CustomerID = int.Parse(Session["userID"].ToString())
            });
            if (isInserted)
                Response.Redirect("deliveryAddresses.aspx");
            else
                lblStatus.Text = "Could not insert address";
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}