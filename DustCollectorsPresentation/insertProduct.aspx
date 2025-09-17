<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="insertProduct.aspx.cs" Inherits="DustCollectorsPresentation.insertProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Insert Product</title>
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
							<h3>
							Shoe Information
							</h3>
								</div>
							</div>
						<div class="row p-b-25">
												

						<div class="col-sm-6 p-b-5">
							<b><label class="stext-102 cl3" for="name">Name</label></b>
							<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtFirstName" runat="server" type="text" name="name"></asp:TextBox>
						</div>

						<div class="col-sm-6 p-b-5">
							<b><label class="stext-102 cl3" for="email">Selct A Brand</label></b>
							
							<asp:DropDownList  class="size-111 bor8 stext-102 cl2 p-lr-20" ID="DropDownList1" runat="server">
								
								<asp:ListItem></asp:ListItem>
								<asp:ListItem>Adidas</asp:ListItem>
								<asp:ListItem style="color:blue;">Add A Brand</asp:ListItem>
							</asp:DropDownList>
							
						</div>
						</div>
						<div class="row p-b-25">
							<div class="col-sm-6 p-b-5">
								<b><label class="stext-102 cl3" for="name">Select A category</label></b>
								
								<asp:DropDownList class="size-111 bor8 stext-102 cl2 p-lr-20" ID="DropDownList2" runat="server">
									<asp:ListItem>Sneakers</asp:ListItem>
									<asp:ListItem style="color:blue;">Add A Category</asp:ListItem>
								</asp:DropDownList>
								
							</div>

							<div class="col-sm-6 p-b-5">
								<b><label class="stext-102 cl3" for="email">Main Image URL</label></b>
								<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtPhoneNumber" runat="server" type="phoneNumber" name="phoneNumber"></asp:TextBox>
							
							</div>
						</div>
						<div class="row p-b-25">
							<div class="col-12 p-b-5">
							<b><label class="stext-102 cl3" for="email">Description</label></b>
									<textarea class="size-110 bor8 stext-102 cl2 p-lr-20 p-tb-10" id="TextArea1" cols="20" rows="2"></textarea>
							
							
							</div>
						</div>

						<div class="row p-b-25">
							<div class="col-sm-6 p-b-5">
								<h4>Shoe Variants</h4>
							
							</div>
							
						</div>
						<div class="row p-b-25" id="shoe_variants_table" runat="server">
						
						<div class="wrap-table-shopping-cart">
							<table class="table-shopping-cart">
								<tr class="table_head">
									<th class="column-1">Image</th>
									<th class="column-1">Colourway</th>
									<th class="column-1">Gender</th>
									<th class="column-1">Price</th>
									<th class="column-1"><asp:Button ID="Button2" runat="server" Text="Add New variant" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" />
										</th>
								
								</tr>

								<tr class="table_row">
									<td class="column-1">
										<div>
											<img src="images/item-cart-04.jpg" alt="IMG">
										</div>
									</td>
									<td class="column-1">Blue</td>
									<td class="column-1">Male(Adults)</td>
									<td class="column-1">100</td>
									<td class="column-1">
										<a ID="linkToEdit" runat="server" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" >Edit</a>
										<button class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10">Deactivate</button>
									</td>
								</tr>

								<tr class="table_row">
									<td class="column-1">
										<div>
											<img src="images/item-cart-05.jpg" alt="IMG">
										</div>
									</td>
									<td class="column-1">Blue</td>
									<td class="column-1">Female(Adults)</td>
									<td class="column-1">100</td>
									<td class="column-1">
										<a ID="A1" runat="server" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" >Edit</a>
										<button class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10">Deactivate</button>
									</td>
									
								</tr>
							</table>
						</div>
								</div>
				</div>
							<div class="row p-b-25">
							<div class="col-sm-6 p-b-5">
								<b><label>NB: Before submitting you must have at least one product variant.</label></b>
								</div>
								</div>
							<div class="row p-b-25">
							<div class="col-sm-6 p-b-5">
						<asp:Button ID="btnSaveChanges" runat="server" Text="Submit" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" />
						</div>
					</div>
						</form>
				</div>
			</div>
		</div>
	</div>
		</div>
</asp:Content>
