<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="shoeVariantForm.aspx.cs" Inherits="DustCollectorsPresentation.shoeVariantForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Add Shoe | Shoe Variant</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-bottom:50px;">
        <div class="bor10 m-t-50 p-t-43 p-b-40">
            <div class="row">
                <div class="col-sm-10 col-md-8 col-lg-6 m-lr-auto">
                    <div class="m-l-25 m-r--38 m-lr-0-xl">
                        <form class="w-full">
                            <div class="row p-b-25">
                                <div class="col-sm-6 p-b-5">
                                    <h3>Nike Air Force One Black (Adult Male) Information</h3>
                                </div>
                            </div>
                            <div class="row p-b-25">
                                <div class="col-sm-6 p-b-5">
                                     <b><label class="stext-102 cl3" for="email">Selct A Colourway</label></b>
                               
                                    
                                    <asp:DropDownList  class="size-111 bor8 stext-102 cl2 p-lr-20" ID="DropDownList2" runat="server">
								
                                    <asp:ListItem>Grey</asp:ListItem>
                                    <asp:ListItem>Black</asp:ListItem>
                                    <asp:ListItem style="color:blue;">Add A New Colourway</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <div class="col-sm-6 p-b-5">
                                    <b><label class="stext-102 cl3" for="email">Selct Gender And Age Group</label></b>
                               
                                    
                                    <asp:DropDownList  class="size-111 bor8 stext-102 cl2 p-lr-20" ID="DropDownList1" runat="server">
								
                                    <asp:ListItem>Male (Adults)</asp:ListItem>
                                    <asp:ListItem>Female (Adults)</asp:ListItem>
                                    <asp:ListItem style="color:blue;">Add A New Gender And Age Group</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="row p-b-25">
                                <div class="col-sm-6 p-b-5">
                                    <b><label class="stext-102 cl3" for="name">Price</label></b>
                                    <asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="TextBox1" runat="server" type="text" name="name"></asp:TextBox>
                                </div>

                                <div class="col-sm-6 p-b-5">
                                    <b><label class="stext-102 cl3" for="name">Discount Percentage</label></b>
                                    <asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="TextBox2" runat="server" type="text" name="name"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row p-b-25">
                                <div class="col-sm-6 p-b-5">
                                    <b><label class="stext-102 cl3" for="name">Main Image URL</label></b>
                                    <asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="TextBox3" runat="server" type="text" name="name"></asp:TextBox>
                                </div>

                                <div class="col-sm-6 p-b-5">
                                    <b><label class="stext-102 cl3" for="email">Is Available</label></b>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </div>
                            </div>
                             <div class="row p-b-25">
                                 <div class="row p-b-25" id="shoe_variants_table" runat="server">
						            <div class="wrap-table-shopping-cart">
							            <table class="table-shopping-cart">
								            <tr class="table_head">
									            <th class="column-1">Size</th>
									            <th class="column-1">QTY In Stock</th>
									            <th class="column-1">Is Available</th>
									          
									            <th class="column-1"><asp:Button ID="Button2" runat="server" Text="Add New Size" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" /></th>
								            </tr>

								            <tr class="table_row">
									            <td class="column-1">7 (UK)</td>
									            <td class="column-1">100</td>
									            <td class="column-1">Yes</td>
									            <td class="column-1">
										            <a ID="linkToEdit" runat="server" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10">Edit</a>
										            <button class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10">Remove</button>
									            </td>
								            </tr>

								
							            </table>
						            </div>
								</div>
                             </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
