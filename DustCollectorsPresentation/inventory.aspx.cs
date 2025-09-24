using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class prodDashboard : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        dynamic shoes; 
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (Request.QueryString["availability"] != null)
            {
                if (Request.QueryString["availability"].Equals("available"))
                    shoes = client.getActiveProducts();
                else if (Request.QueryString["availability"].Equals("unavailable"))
                    shoes = client.getInactiveProducts();
                else
                    shoes = client.getAllProducts();
            } else
            {

                Response.Redirect("inventory.aspx?availability=all");
            }

            if (shoes != null)
            {
                foreach (DisplayProdCatalog shoe in shoes)
                {
                    product_section.InnerHtml += "<div class='col -sm-6 col-md-4 col-lg-3 p-b-35 isotope-item women'>";
                    product_section.InnerHtml += "<!-- Block2 -->";
                    product_section.InnerHtml += "<div class='block2'>";
                    product_section.InnerHtml += "<div class='block2-pic hov-img0'>";
                    product_section.InnerHtml += "<img src='" + shoe.mainImageURL + "' alt='IMG-PRODUCT'>";


                    product_section.InnerHtml += "<a href='editProduct.aspx?prodId="+shoe.Id+"' class='block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04'>";
                    product_section.InnerHtml += "Edit";
                    product_section.InnerHtml += "</a>";
                    product_section.InnerHtml += "</div>";

                    product_section.InnerHtml += "<div class='block2-txt flex-w flex-t p-t-14'>";
                    product_section.InnerHtml += "<div class='block2-txt-child1 flex-col-l'>";
                    product_section.InnerHtml += "<a href='editProduct.aspx?prodId=" + shoe.Id + "' class='stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6'>";
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
        /*
        private void populateTable()
        {
            foreach(ProdForTblManagement p in prods)
            {
                if(p != null)
                {
                    // create a new table row
                    TableRow tr = new TableRow();
                    tr.CssClass = "column-1";
                    // add cells
                    // image cell
                    TableCell imgCell = new TableCell();
                    imgCell.CssClass = "column-1";
                    Image image = new Image();
                    image.Width = 80;
                    image.Height = 80;
                    image.ImageUrl = p.MainImgURL;
                    image.AlternateText = p.Name;
                    imgCell.Controls.Add(image);
                    tr.Cells.Add(imgCell);
                    // name celll
                    TableCell nameCell = new TableCell();
                    nameCell.CssClass = "column-1";
                    nameCell.Text = p.Name;
                    tr.Cells.Add(nameCell);
                    // brand name
                    TableCell brandName = new TableCell();
                    brandName.CssClass = "column-1";
                    brandName.Text = p.BrandName;
                    tr.Cells.Add(brandName);

                    // price
                    TableCell priceCell = new TableCell();
                    priceCell.CssClass = "column-1";
                    priceCell.Text = "R "+ p.Price.ToString();
                    tr.Cells.Add(priceCell);
                    // category cell
                    TableCell categoryCell = new TableCell();
                    categoryCell.CssClass = "column-1";
                    categoryCell.Text = p.CategoryName;
                    tr.Cells.Add(categoryCell);
                    // gender cell
                    TableCell genderCell = new TableCell();
                    genderCell.Text = p.GenderAgeCategory;
                    genderCell.CssClass = "column-1";
                    tr.Cells.Add(genderCell);

                    // colourway cell
                    TableCell dateAddedCell = new TableCell();
                    dateAddedCell.Text = p.DateAdded.ToString();
                    dateAddedCell.CssClass = "column-1";
                    tr.Cells.Add(dateAddedCell);

                    // is available cell
                    TableCell amountInStock = new TableCell();
                    amountInStock.CssClass = "column-1";
                    amountInStock.Text = p.AmountInStock.ToString();
                    tr.Cells.Add(amountInStock);

                    // activate/reactivate button
                    TableCell activateOrReactivateBtn = new TableCell();


                    productsTbl.Rows.Add(tr);

                }
            }
        }*/
    }
}