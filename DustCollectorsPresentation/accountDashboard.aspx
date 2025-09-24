<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="accountDashboard.aspx.cs" Inherits="DustCollectorsPresentation.accountDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>My Account</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<section class="bg0 p-t-104 p-b-116" id="details" runat="server" visible="true">
		<div class="container">
			<div class="flex-w flex-tr">
				<div class="size-210 bor10 flex-w flex-col-m p-lr-93 p-tb-30 p-lr-15-lg w-full-md">
					<h4>
						Profile
					</h4>
					<div class="=p-t-55">
					<ul>
						<li class="bor18">
							<a href="personalDetails.aspx" class="stext-107 cl7 hov-cl1 trans-04">
								Personal Details
							</a>
						</li>

						<li class="bor18" id="customerAddressBook" runat="server">
							<a href="deliveryAddresses.aspx" class="stext-107 cl7 hov-cl1 trans-04">
								Address Book
							</a>
						</li>

						<li class="bor18">
							<a href="securityDetails.aspx" class="stext-107 cl7 hov-cl1 trans-04">
								Change Password
							</a>
						</li>

						
					</ul>
						</div>
				
				</div>
				<div class="size-210 bor10 p-lr-70 p-t-55 p-b-70 p-lr-15-lg w-full-md" id="customerOrders" runat="server" visible="true">
					<h4>
						Orders
					</h4>
					<div class="=p-t-55">
					<ul>
						<li class="bor18">
							<a href="#" class="stext-107 cl7 hov-cl1 trans-04">
								Orders
							</a>
						</li>

						<li class="bor18">
							<a href="#" class="stext-107 cl7 hov-cl1 trans-04">
								Product Reviews
							</a>
						</li>

						<li class="bor18">
							<a href="#" class="stext-107 cl7 hov-cl1 trans-04">
								Invoices
							</a>
						</li>

						
					</ul>
						</div>
				
					
				</div>

					
			</div>
		</div>
	</section>	
</asp:Content>
