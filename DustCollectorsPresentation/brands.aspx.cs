using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class brands : System.Web.UI.Page
    {
		Service1Client client = new Service1Client();
		
        protected void Page_Load(object sender, EventArgs e)
        {
			if(!IsPostBack)
            {
				availability.Items.Add(new ListItem("All", "all"));
				availability.Items.Add(new ListItem("Available", "available"));
				availability.Items.Add(new ListItem("Unavailable", "unavailable"));
			}
			if (availability.SelectedValue.Equals("available"))
			{
				displayBrands(1);
			}
			else if (availability.SelectedValue.Equals("unavailable"))
			{
				displayBrands(0);
			}
			else
			{
				displayBrands(2);
			}

			//displayBrands((availability.SelectedValue.Equals("available")) ? true : false);


		}

        protected void availability_SelectedIndexChanged(object sender, EventArgs e)
        {
			

			

		}

		private void displayBrands(int isAvailable)
        {
			dynamic brands = client.getBrands(isAvailable);
			
			if (brands != null)
			{
				brandSection.InnerHtml = "";
				foreach (BrandDTO brand in brands)
				{
					brandSection.InnerHtml += "<div class='col-sm-6 col-md-4 col-lg-3 p-b-35 isotope-item women'>";
					brandSection.InnerHtml += "<!-- Block2 -->";
					brandSection.InnerHtml += "<div class='block2'>";
					brandSection.InnerHtml += "<div class='block2-pic hov-img0'>";
					brandSection.InnerHtml += "<img src='" + brand.mailLogoURL + "' alt='" + brand.name + " logo'>";


					brandSection.InnerHtml += "<a href='brandForm.aspx?brandId=" + brand.Id + "' class='block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1'>";
					brandSection.InnerHtml += "View Details";
					brandSection.InnerHtml += "</a>";
					brandSection.InnerHtml += "</div>";

					brandSection.InnerHtml += "<div class='block2-txt flex-w flex-t p-t-14'>";
					brandSection.InnerHtml += "<div class='block2-txt-child1 flex-col-l'>";
					brandSection.InnerHtml += "<a href='brandForm.aspx?brandId=" + brand.Id + "' class='stext-104 cl4 hov-cl1 trans-04 p-b-6'>";
					brandSection.InnerHtml += brand.name;
					brandSection.InnerHtml += "</a>";

					brandSection.InnerHtml += "<span class='stext-105 cl3'>";
					brandSection.InnerHtml += "Added on " + brand.dateAdded.ToString();
					brandSection.InnerHtml += "</span>";
					brandSection.InnerHtml += "</div>";

					brandSection.InnerHtml += "<div class='block2-txt-child2 flex-r p-t-3'>";

					brandSection.InnerHtml += "</div>";
					brandSection.InnerHtml += "</div>";
					brandSection.InnerHtml += "</div>";
					brandSection.InnerHtml += "</div>";
				}
			}
		}
    }
}