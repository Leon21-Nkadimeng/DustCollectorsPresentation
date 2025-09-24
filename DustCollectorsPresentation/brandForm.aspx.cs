using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class insertBrand : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        int brandId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["brandId"] != null)
            {
                try
                {
                       
                    brandId = int.Parse(Request.QueryString["brandId"].ToString());
                    var brand = client.getBrand(brandId);
                    if (brand != null && !IsPostBack)
                    {
                        pageTitle.InnerText = brand.name + " (SKU: " + brand.Id + ")";
                        brandId = brand.Id;
                        logoSection.Visible = true;
                        txtName.Text = brand.name;
                        txtDescription.Text = brand.description;
                        txtMainLogo.Text = brand.mailLogoURL;
                        logoSection.InnerHtml = "<img src='" + brand.mailLogoURL + "' style='width:900px;height:auto;'/>";
                        isActive.Checked = brand.isActive;
                        saveChangesSection.Visible = true;
                        submitSection.Visible = false;

                        breadCrumb.InnerHtml+= "<a href='brands.aspx' class='stext-109 cl8 hov-cl1 trans-04'>";
                        breadCrumb.InnerHtml += "Brands";
                        breadCrumb.InnerHtml += "<i class='fa fa-angle-right m-l-9 m-r-10' aria-hidden='true'></i>";
                        breadCrumb.InnerHtml += "</a>";
                        breadCrumb.InnerHtml += "<span class='stext-109 cl4'>";
                        breadCrumb.InnerHtml += "Brand Form";
                        breadCrumb.InnerHtml += "</span>";
                    }
                }
                catch(Exception ex)
                {
                    Response.Redirect("brands.aspx");
                }
                
               
            }
            else
            {
                breadCrumb.InnerHtml += "<span class='stext-109 cl4'>";
                breadCrumb.InnerHtml += "Brand Form";
                breadCrumb.InnerHtml += "</span>";
                btnSubmit.Visible = true;
                btnSaveChanges.Visible = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isInserted = client.InsertBrand(new BrandDTO() { name = txtName.Text, description = txtDescription.Text, mailLogoURL = txtMainLogo.Text, isActive = isActive.Checked});
            if (isInserted)
                lblStatus.Text = "Brand inserted successfully";
            else
                lblStatus.Text = "Brand already exists";
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            BrandDTO brand = new BrandDTO()
            {
                name = txtName.Text,
                description = txtDescription.Text,
                mailLogoURL = txtMainLogo.Text,
                Id = brandId,
                isActive = isActive.Checked
            };
            bool isUpdated = client.updateBrand(brand);
            if (isUpdated)
                lblStatus.Text = "Brand is successfully Updated";
            else
                lblStatus.Text = "could not update brand";

        }


       
    }
}