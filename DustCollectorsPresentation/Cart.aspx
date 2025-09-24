<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="DustCollectorsPresentation.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Cart</title>
	<style>
		.instockTag{
			font-weight: bold;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<!-- breadcrumb -->
	<div class="container">
		<div class="bread-crumb flex-w p-l-25 p-r-15 p-t-30 p-lr-0-lg">
			<a href="index.html" class="stext-109 cl8 hov-cl1 trans-04">
				Home
				<i class="fa fa-angle-right m-l-9 m-r-10" aria-hidden="true"></i>
			</a>

			<span class="stext-109 cl4">
				Shoping Cart
			</span>
		</div>
	</div>
    	<!-- Shoping Cart -->
	<form class="bg0 p-t-75 p-b-85">
		<div class="container">
			<div class="row">
				<div class="col-sm-23 col-xl-7 m-lr-auto m-b-50">
					<div class="m-l-25 m-r--38 m-lr-0-xl">
						<div class="wrap-table-shopping-cart">
					
							
									
								<div class="wrap-table-shopping-cart">
									<asp:Table class="table-shopping-cart" ID="cartTbl" runat="server">
										<asp:TableHeaderRow class="table_head" ID="tblHeaderRow" runat="server">
											<asp:TableHeaderCell class="column-1"></asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">Image</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">Name</asp:TableHeaderCell>
											
											
											<asp:TableHeaderCell class="column-1">Price</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">QTY</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-2">Total Price</asp:TableHeaderCell>
										</asp:TableHeaderRow>
										
					
								

								</asp:Table>
					
					</div>
						</div>

						
					</div>
				</div>

			
								
									
										

				<div class="col-sm-10 col-lg-7 col-xl-5 m-lr-auto m-b-50">
					<div class="bor10 p-lr-40 p-t-30 p-b-40 m-l-63 m-r-40 m-lr-0-xl p-lr-15-sm">
						<h4 class="mtext-109 cl2 p-b-30">
							Cart Totals
						</h4>

						<div class="flex-w flex-t bor12 p-b-13">
							<div class="size-208">
								<span class="stext-110 cl2">
									Subtotal:
								</span>
							</div>

							<div class="size-209">
								<span class="mtext-110 cl2" id="subtotalSpan" runat="server">
									
								</span>
							</div>
						</div>
						<div class="flex-w flex-t p-t-27 p-b-33">
							

							<div class="size-209 p-t-1">
								<span class="mtext-110 cl2" id="VATSpan" runat="server">
									
								</span>
							</div>
							
							<div class="size-209 p-t-1">
								<span class="mtext-101 cl2">
									Grand Total:
								</span>
								<span class="mtext-110 cl2" id="grandTotalSpan" runat="server">
									
								</span>
							</div>
						</div>
						<div class="flex-w flex-t bor12 p-t-15 p-b-30">
							

							
								<div class="p-t-15">
									
									<span class="stext-110 cl2">
									Shipping Address:
								</span>
									
										<asp:DropDownList ID="addresses" style="width:100%;" class="size-111 bor8 stext-102 cl2 p-lr-20" runat="server">
											<asp:ListItem>Select Address</asp:ListItem>
										</asp:DropDownList>
										<asp:Label ID="lblSelectAddress" runat="server" Text="Select Delivery Address*" style="color:red;" Visible="false"></asp:Label>
								</div>
							
						</div>
						<asp:Button ID="btnCheckout" runat="server" Text="Proceed to Checkout" class="flex-c-m stext-101 cl0 size-116 bg3 bor14 hov-btn3 p-lr-15 trans-04 pointer" OnClick="btnCheckout_Click" />
						
					</div>
				</div>
			</div>
		</div>
	</form>
		
	
</asp:Content>
