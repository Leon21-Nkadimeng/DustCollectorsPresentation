using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class Cart : System.Web.UI.Page
    {

        private Service1Client client = new Service1Client();
        private int userId;
        private decimal subtotal = 0;
        private decimal grandTotal = 0;
        private decimal VATPercentage = 15;
        //private decimal grandTotal = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                userId = int.Parse(Session["UserID"].ToString());
                dynamic prods = client.getCartProducts(userId);
                if(!IsPostBack)
                {
                    fillAddressDropdown();
                }
                if (prods != null)
                {
                    decimal total = 0;
                    foreach (CartProduct p in prods)
                    {
                        TableRow tr = new TableRow();

                        TableCell removeBtnCell = new TableCell();
                        removeBtnCell.CssClass = "column-1";
                        Button remove = new Button();
                        remove.Text = "Remove";
                        remove.Click += remove_Click;
                        remove.ID = p.SizeID.ToString();
                        removeBtnCell.Controls.Add(remove);
                        tr.Cells.Add(removeBtnCell);

                        

                        TableCell imageCell = new TableCell();
                        imageCell.CssClass = "column-3";
                        Image img = new Image();
                        img.ImageUrl = p.imageURL;
                        img.Width = 60;
                        imageCell.Controls.Add(img);
                        tr.Cells.Add(imageCell);

                        TableCell nameCell = new TableCell();
                        nameCell.CssClass = "column-2";
                        Label lblName = new Label();
                        lblName.Text = p.name +" "+ p.size;
                        nameCell.Controls.Add(lblName);


                        Label lblStock = new Label();
                        lblStock.Text = (p.amountInStock > 0) ? "In Stock" : "Out Of Stock";
                        lblStock.Font.Bold = true;
                        nameCell.Controls.Add(lblStock);
                        tr.Cells.Add(nameCell);

                        TableCell priceCell = new TableCell();
                        priceCell.Text = "R" + p.Price.ToString();
                        tr.Cells.Add(priceCell);

                        TableCell qtyCell = new TableCell();
                        qtyCell.Text = p.QTY.ToString();
                        tr.Cells.Add(qtyCell);

                        TableCell totalPriceCell = new TableCell();
                        totalPriceCell.Text = "R"+(p.Price * p.QTY).ToString();
                        tr.Cells.Add(totalPriceCell);
                        total += (p.Price * p.QTY);
                        cartTbl.Rows.Add(tr);
                    }

                    subtotalSpan.InnerText = "R" + total.ToString("0.00");
                    subtotal = total;
                    decimal vat = total * (decimal)0.15;
                    
                    VATSpan.InnerText = "VAT (15%): R" + vat.ToString("0.00");
                    grandTotalSpan.InnerText = "R" + (total + vat).ToString("0.00");
                }
            }
        }

        protected void remove_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            client.removeItemFromCart(userId, int.Parse(btn.ID.ToString()));
            Response.Redirect("Cart.aspx");
        }

        private void fillAddressDropdown()
        {
            dynamic addresses = client.GetCustomerAddresses(int.Parse(Session["UserID"].ToString()));
            if(addresses != null)
            {
                addresses.Items.Add(new ListItem("Create New Addresses", "new"));
                foreach(var c in addresses)
                {
                    if(c != null)
                    {
                        ListItem item = new ListItem();
                        item.Text = c.StreetAddress + ", " + c.CityOrTown + ", " + c.ComplexOrBuilding + ", " + c.PostalCode;
                        item.Value = c.Id.ToString();
                        this.addresses.Items.Add(item);
                    }
                }
            } 
            else
            {

            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {

        }
    }
}