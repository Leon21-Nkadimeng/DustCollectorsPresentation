using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class deliveryAddresses : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (Session["SessionID"] != null && Session["UserID"] != null && Session["Username"] != null && Session["UserType"] != null)
            {
                try
                {
                    deliveryAddressesSection.InnerHtml = "<table class='table-shopping-cart'>";
                    deliveryAddressesSection.InnerHtml += "<tr class='table_head'>";
                    deliveryAddressesSection.InnerHtml += "<th class='column-1'><h4>Delivery</h4></th>";
                    deliveryAddressesSection.InnerHtml += "<th class='column-2'><h4>Addresses</h4></th>";
                    deliveryAddressesSection.InnerHtml += "<th class='column-3'></th>";
                    deliveryAddressesSection.InnerHtml += "<th class='column-4'></th>";
                    deliveryAddressesSection.InnerHtml += "<th class='column-5'>";
                    deliveryAddressesSection.InnerHtml += "<a href='addressForm.aspx?insertingAddress=true' class='flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer' style='font-weight:normal;text-align:center;'>New Address</a>";
                    deliveryAddressesSection.InnerHtml += "</th>";
                    deliveryAddressesSection.InnerHtml += "</tr>";
                    CustomerAddress[] addresses = client.GetCustomerAddresses(int.Parse(Session["UserID"].ToString()));
                    if(addresses != null)
                    {
                       
                        foreach(CustomerAddress a in addresses)
                        {
                            if(a != null)
                            {
                                
                                deliveryAddressesSection.InnerHtml += "<tr class='table_row'>";

                                deliveryAddressesSection.InnerHtml += "<td class='column-1'><span>" + a.ComplexOrBuilding + ",</span><span>" + a.StreetAddress+ ", " +a.Suburb+",</span><span>" + a.CityOrTown + ", " + a.Province+", "+ a.PostalCode + "</span></td>";
                                deliveryAddressesSection.InnerHtml += "<td class='column-2'></td>";
                                deliveryAddressesSection.InnerHtml+=" <td class='column-3'>";

                                deliveryAddressesSection.InnerHtml+="</td>";
                                deliveryAddressesSection.InnerHtml+="<td class='column-4'></td>";
                                deliveryAddressesSection.InnerHtml+="<td class='column-5'>";
                                deliveryAddressesSection.InnerHtml+= "<a href='addressForm.aspx?editingAddress=true&addressId="+a.Id+"' class='flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer' style='margin-bottom:10px;'>Edit</a>";
                                deliveryAddressesSection.InnerHtml+= "<button ID='btnDeleteAddress' runat='server' class='flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer'>Delete</button>";

                                deliveryAddressesSection.InnerHtml+="</td>";
                                deliveryAddressesSection.InnerHtml+="</tr>";
                            }
                        }
                    }
                    deliveryAddressesSection.InnerHtml += "</table>";
                }
                catch (FormatException ex)
                {

                }
            } else
            {
                Response.Redirect("accountDashboard.aspx");
            }
        }

    
    }
}