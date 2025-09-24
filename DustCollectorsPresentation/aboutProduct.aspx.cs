using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class aboutProduct : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Request.QueryString["prodId"] != null)
            {
                if (!IsPostBack)
                {
                    
                    try
                    {
                        
                        int imgId = int.Parse(Request.QueryString["prodId"]);
                        ProductDetail details = client.getProductDetails(imgId);

                        if (details != null)
                        {
                            breadCrumb.InnerHtml += "<span class='stext-109 cl4'>";
                            breadCrumb.InnerHtml += "About Shoe";
                            breadCrumb.InnerHtml += "</span>";

                            imgSection.InnerHtml += "<div class='slick3 gallery-lb'>";
                            imgSection.InnerHtml += "<div class='item-slick3' data-thumb='" + details.MainImgURL + "'>";
                            imgSection.InnerHtml += "<div class='wrap-pic-w pos-relative'>";
                            imgSection.InnerHtml += "<img src='" + details.MainImgURL + "' alt='IMG-PRODUCT'>";
                            imgSection.InnerHtml += "</div>";
                            imgSection.InnerHtml += "</div>";
                            imgSection.InnerHtml += "</div>";

                            prodName.InnerText = details.Name;

                            prodPrice.InnerText = "R" + details.Price.ToString();
                            prodDescription.InnerText = details.Description;
                            // fill in the sizes
                            sizesList.Items.Add(new ListItem("", "nothing"));
                            foreach (ProductSizeDTO size in details.sizes)
                            {
                                sizesList.Items.Add(new ListItem(size.SizeTag + " " + size.System, size.Id.ToString()));
                            }
                            
                        }
                        else { Response.Redirect("index.aspx"); }
                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("index.aspx");
                    }
                }
            } else
            {
                Response.Redirect("index.aspx");
            }

            if(Session["UserID"] == null)
            {
                btnAddToCart.Visible = false;
                txtQTY.Visible = false;
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            lblAddedToCart.Visible = false;
            lblCouldNotAddToCart.Visible = false;
            int sizeId = int.Parse(sizesList.SelectedValue);
            int qty = int.Parse(txtQTY.Text);
            int userId = int.Parse(Session["UserID"].ToString());

            bool isAdded = client.AddItemToCart(userId, sizeId, qty);
            if (isAdded)
                lblAddedToCart.Visible = true;
            else
                lblCouldNotAddToCart.Visible = true;
        }
    }
}