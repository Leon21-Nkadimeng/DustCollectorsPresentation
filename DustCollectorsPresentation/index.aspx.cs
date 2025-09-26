using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class index : System.Web.UI.Page
    {
		Service1Client client = new Service1Client();
		dynamic shoes;
		dynamic shoeCategories;
		dynamic shoeColourways;
		static string gender = "all";
		protected void Page_Load(object sender, EventArgs e)
		{
			//if(Session["UserType"] == null || Session["UserType"].Equals(""))
			shoeCategories = client.getCategories(true);
			shoeColourways = client.getColourways();
			if(!IsPostBack && shoeCategories != null && shoeColourways != null)
            {
				
				colourways.Items.Add(new ListItem("All", "-1"));
				colourways.SelectedValue = "-1";
				foreach(ColourwayDTO c in shoeColourways)
                {
					if(c != null)
                    {
						colourways.Items.Add(new ListItem(c.name, c.id.ToString()));
                    }
                }


				categories.Items.Add(new ListItem("All", "-1"));
				categories.SelectedValue = "-1";
				foreach(CategoryDTO c in shoeCategories)
                {
					if(c != null)
                    {
						categories.Items.Add(new ListItem(c.name, c.id.ToString()));
                    }
                }
				categories_SelectedIndexChanged(sender, e);

			}

			
			//displayShoesByGender(gender);
		}
		/*
		void insertionSortAsc()
        {
			if(shoes != null)
            {
				for(int i = 1; i < shoes.Length; i++)
                {
					CatalogDisplayShoe shoe = shoes[i];
					int j = i - 1;
					
					while(j >= 0 && shoes[j].price > shoe.price)
                    {
						shoes[j + 1] = shoes[j];
						j = j - 1;
                    }
					shoes[j + 1] = shoe;
                }
            }
			
        }
		void insertionSortDesc()
		{
			if (shoes != null)
			{
				for (int i = 1; i < shoes.Length; i++)
				{
					CatalogDisplayShoe shoe = shoes[i];
					int j = i - 1;

					while (j >= 0 && shoes[j].price < shoe.price)
					{
						shoes[j + 1] = shoes[j];
						j = j - 1;
					}
					shoes[j + 1] = shoe;
				}
			}

		}
		protected void displayShoesByGender(string gender)
        {
			
			if (shoes != null)
			{
				lblGender.Text = gender;
				product_section.InnerHtml = "";
				foreach (CatalogDisplayShoe shoe in shoes)
				{
					if (gender.Equals(shoe.gender))
					{
						product_section.InnerHtml += "<div class='col -sm-6 col-md-4 col-lg-3 p-b-35 isotope-item women'>";
						product_section.InnerHtml += "<!-- Block2 -->";
						product_section.InnerHtml += "<div class='block2'>";
						product_section.InnerHtml += "<div class='block2-pic hov-img0'>";
						product_section.InnerHtml += "<img src='"+shoe.MainImgURL+"' alt='IMG-PRODUCT'>";

						product_section.InnerHtml += "<a href='#' class='block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1'>";
						product_section.InnerHtml += "Quick View";
						product_section.InnerHtml += "</a>";
						product_section.InnerHtml += "</div>";

						product_section.InnerHtml += "<div class='block2-txt flex-w flex-t p-t-14'>";
						product_section.InnerHtml += "<div class='block2-txt-child1 flex-col-l'>";
						product_section.InnerHtml += "<a href='aboutProduct.aspx?prodId="+shoe.shoeID+"&gender="+gender+"' class='stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6'>";
						product_section.InnerHtml += shoe.brandName + " " + shoe.shoeName + " (" + shoe.gender + ")";
						product_section.InnerHtml += "</a>";

						product_section.InnerHtml += "<span class='stext-105 cl3'>";
						product_section.InnerHtml += "R" + shoe.price;
						product_section.InnerHtml += "</span>";
						product_section.InnerHtml += "</div>";

						product_section.InnerHtml += "<div class='block2-txt-child2 flex-r p-t-3'>";
						product_section.InnerHtml += "<a href='#' class='btn-addwish-b2 dis-block pos-relative js-addwish-b2'>";
						product_section.InnerHtml += "<img class='icon-heart1 dis-block trans-04' src='images/icons/icon-heart-01.png' alt='ICON'>";
						product_section.InnerHtml += "<img class='icon-heart2 dis-block trans-04 ab-t-l' src='images/icons/icon-heart-02.png' alt='ICON'>";
						product_section.InnerHtml += "</a>";
						product_section.InnerHtml += "</div>";
						product_section.InnerHtml += "</div>";
						product_section.InnerHtml += "</div>";
						product_section.InnerHtml += "</div>";
					} else if(gender.Equals("all"))
                    {
						product_section.InnerHtml += "<div class='col -sm-6 col-md-4 col-lg-3 p-b-35 isotope-item women'>";
						product_section.InnerHtml += "<!-- Block2 -->";
						product_section.InnerHtml += "<div class='block2'>";
						product_section.InnerHtml += "<div class='block2-pic hov-img0'>";
						product_section.InnerHtml += "<img src='" + shoe.MainImgURL + "' alt='IMG-PRODUCT'>";

						product_section.InnerHtml += "<a href='#' class='block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1'>";
						product_section.InnerHtml += "Quick View";
						product_section.InnerHtml += "</a>";
						product_section.InnerHtml += "</div>";

						product_section.InnerHtml += "<div class='block2-txt flex-w flex-t p-t-14'>";
						product_section.InnerHtml += "<div class='block2-txt-child1 flex-col-l'>";
						product_section.InnerHtml += "<a href='product-detail.html' class='stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6'>";
						product_section.InnerHtml += shoe.brandName + " " + shoe.shoeName + " (" + shoe.gender + ")";
						product_section.InnerHtml += "</a>";

						product_section.InnerHtml += "<span class='stext-105 cl3'>";
						product_section.InnerHtml += "R" + shoe.price;
						product_section.InnerHtml += "</span>";
						product_section.InnerHtml += "</div>";

						product_section.InnerHtml += "<div class='block2-txt-child2 flex-r p-t-3'>";
						product_section.InnerHtml += "<a href='#' class='btn-addwish-b2 dis-block pos-relative js-addwish-b2'>";
						product_section.InnerHtml += "<img class='icon-heart1 dis-block trans-04' src='images/icons/icon-heart-01.png' alt='ICON'>";
						product_section.InnerHtml += "<img class='icon-heart2 dis-block trans-04 ab-t-l' src='images/icons/icon-heart-02.png' alt='ICON'>";
						product_section.InnerHtml += "</a>";
						product_section.InnerHtml += "</div>";
						product_section.InnerHtml += "</div>";
						product_section.InnerHtml += "</div>";
						product_section.InnerHtml += "</div>";
					}

				}
			}
		}
		*/
        protected void btnSortByPriceAsc_Click(object sender, EventArgs e)
        {
			//insertionSortAsc();
			//displayShoesByGender(gender);

		}
		protected void btnSortByPriceDesc_Click(object sender, EventArgs e)
        {
			//insertionSortDesc();
			//displayShoesByGender(gender);

		}
		protected void btnWomen_Click(object sender, EventArgs e)
        {
			gender = "women";
			//displayShoesByGender(gender);

		}

        protected void btnMen_Click(object sender, EventArgs e)
        {
			gender = "men";
			//displayShoesByGender(gender);
		}

        protected void btnBoys_Click(object sender, EventArgs e)
        {
			gender = "boys";
			//displayShoesByGender(gender);
		}

        protected void btnGirls_Click(object sender, EventArgs e)
        {
			gender = "girls";
			//displayShoesByGender(gender);
		}

        protected void btnAllProds_Click(object sender, EventArgs e)
        {
			gender = "all";
			//displayShoesByGender(gender);
        }
		protected void colourways_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		protected void categories_SelectedIndexChanged(object sender, EventArgs e)
        {
			shoes = client.getProductsByCategory(int.Parse(categories.SelectedValue.ToString()));
			
			
			if (shoes != null)
			{
				product_section.InnerHtml = "";
				foreach (DisplayProdCatalog shoe in shoes)
				{
					product_section.InnerHtml += "<div class='col-sm-6 col-md-4 col-lg-3 p-b-35 isotope-item women'>";
					product_section.InnerHtml += "<!-- Block2 -->";
					product_section.InnerHtml += "<div class='block2'>";
					product_section.InnerHtml += "<div class='block2-pic hov-img0' style='height:200px;'>";
					product_section.InnerHtml += "<img src='" + shoe.mainImageURL + "' alt='" + shoe.BrandName + " " + shoe.Name + "'>";


					product_section.InnerHtml += "<a href='aboutProduct.aspx?prodId=" + shoe.Id + "' class='block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1'>";
					product_section.InnerHtml += "View Details";
					product_section.InnerHtml += "</a>";
					product_section.InnerHtml += "</div>";

					product_section.InnerHtml += "<div class='block2-txt flex-w flex-t p-t-14'>";
					product_section.InnerHtml += "<div class='block2-txt-child1 flex-col-l'>";
					product_section.InnerHtml += "<a href='aboutProduct.aspx?prodId=" + shoe.Id + "' class='stext-104 cl4 hov-cl1 trans-04 p-b-6'>";
					product_section.InnerHtml += shoe.BrandName + " " + shoe.Name;
					product_section.InnerHtml += "</a>";

					product_section.InnerHtml += "<span class='stext-105 cl3'>";
					product_section.InnerHtml += "R" + shoe.Price;
					product_section.InnerHtml += "</span>";
					product_section.InnerHtml += "</div>";

					product_section.InnerHtml += "<div class='block2-txt-child2 flex-r p-t-3'>";
					product_section.InnerHtml += "<a href='#' class='btn-addwish-b2 dis-block pos-relative js-addwish-b2'>";
					product_section.InnerHtml += "<img class='icon-heart1 dis-block trans-04' src='images/icons/icon-heart-01.png' alt='ICON'>";
					product_section.InnerHtml += "<img class='icon-heart2 dis-block trans-04 ab-t-l' src='images/icons/icon-heart-02.png' alt='ICON'>";
					product_section.InnerHtml += "</a>";
					product_section.InnerHtml += "</div>";
					product_section.InnerHtml += "</div>";
					product_section.InnerHtml += "</div>";
					product_section.InnerHtml += "</div>";
				}
			}
		}
    }
}