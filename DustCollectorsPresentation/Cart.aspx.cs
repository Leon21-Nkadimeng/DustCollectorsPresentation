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
        private decimal total;
        private decimal grandTotal;
        private decimal vat;
        
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                userId = int.Parse(Session["UserID"].ToString());
                dynamic prods = client.getCartProducts(userId);

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
                        lblName.Text = p.name + " " + p.size;
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
                        TextBox txtQty = new TextBox();
                        txtQty.ID = "txt" + p.SizeID.ToString();
                        txtQty.Text = p.QTY.ToString();
                        txtQty.TextMode = TextBoxMode.Number;


                        //qtyCell.Text = p.QTY.ToString();
                        qtyCell.Controls.Add(txtQty);
                        Button update = new Button();
                        update.PostBackUrl = "Cart.aspx";
                        update.Text = "Update";
                        update.ID = "S_" + p.SizeID.ToString();
                        update.Click += update_Click;
                        qtyCell.Controls.Add(update);
                        tr.Cells.Add(qtyCell);

                        TableCell totalPriceCell = new TableCell();
                        totalPriceCell.Text = "R" + (p.Price * p.QTY).ToString();

                        tr.Cells.Add(totalPriceCell);
                        total += (p.Price * p.QTY);
                       ;
                       
                        cartTbl.Rows.Add(tr);
                    }
                    this.total = total;
                    subtotalSpan.InnerText = "R" + total.ToString("0.00");
                   
                    decimal vat = total * (decimal)0.15;
                    this.vat = vat;
                    VATSpan.InnerText = "VAT (15%): R" + vat.ToString("0.00");

                    grandTotal = (total + vat);
                    grandTotalSpan.InnerText = "R" + grandTotal.ToString("0.00");
                }
               
            }
        }
        //private decimal grandTotal = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                if (!IsPostBack)
                {
                    fillAddressDropdown();
                }

               
            } else
            {
                Response.Redirect("index.aspx");
            }
        }
        protected void update_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int sizeId = int.Parse(btn.ID.Substring(2));
            foreach(TableRow tr in cartTbl.Rows)
            {
                if(tr != null)
                {
                    foreach(TableCell tc in tr.Cells)
                    {
                        if(tc != null)
                        {
                            TextBox txtUpdate = (TextBox)tc.FindControl("txt" + sizeId.ToString());
                            if(txtUpdate != null || !txtUpdate.Text.Equals(""))
                            {
                                client.updateCartItem(sizeId, userId, int.Parse(txtUpdate.Text));
                                Response.Redirect("Cart.aspx");
                            }
                        }
                    }
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
            dynamic deliveryAddresses = client.GetCustomerAddresses(int.Parse(Session["UserID"].ToString()));
            if(deliveryAddresses != null)
            {


                // createAddresses.
                addresses.Items.Add(new ListItem("Select An Address", ""));
                addresses.Items.Add(new ListItem("Create New Addresses", "new"));
                foreach(var c in deliveryAddresses)
                {
                    if(c != null)
                    {
                        ListItem item = new ListItem();
                        item.Text = c.StreetAddress + ", " + c.CityOrTown + ", " + c.ComplexOrBuilding + ", " + c.PostalCode;
                        item.Value = c.Id.ToString();
                        addresses.Items.Add(item);
                    }
                }
            } 
            else
            {
                
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if (addresses.SelectedItem.Value.Equals(""))
                lblSelectAddress.Visible = true;
            else if (!addresses.SelectedValue.Equals("new") || !addresses.SelectedItem.Value.Equals(""))
            {
                decimal shipping = (grandTotal > 900) ? 0 : 200;
                grandTotal += shipping;
                lblSelectAddress.Text = client.createInvoice(userId, int.Parse(addresses.SelectedValue.ToString()), total, vat, shipping, grandTotal).ToString();
                dynamic prods = client.getCartProducts(userId);
                lblSelectAddress.Text += " " + client.updateQTYS(prods);
                lblSelectAddress.Text += " " + client.deleteCartItems(userId);
                lblSelectAddress.Visible = true;
            }//  else if ()
            //    Response.Redirect("Checkout.aspx");



        }

        protected void addresses_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (addresses.SelectedItem.Value.Equals("new"))
                Response.Redirect("addressForm.aspx?from=checkout");
        }
    }
}