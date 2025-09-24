<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="brands.aspx.cs" Inherits="DustCollectorsPresentation.brands" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Brands</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
		<div class="bread-crumb flex-w p-l-25 p-r-15 p-t-30 p-lr-0-lg">
			<a href="index.aspx" class="stext-109 cl8 hov-cl1 trans-04">
				Home
				<i class="fa fa-angle-right m-l-9 m-r-10" aria-hidden="true"></i>
			</a>
			

			<span class="stext-109 cl4">
				Brands
			</span>
		</div>
	</div>
 <!-- Products go here >> -->
	<section class="bg0 p-t-23 p-b-140">
		<div class="container">
			<div class="p-b-10">
				<h3 class="ltext-103 cl5">Product Overview</h3>
			</div>
			<div clas5s="flex-w flex-sb-m p-b-52">
				<div class="flex-w flex-c-m m-tb-10">
					<span>Sort By: </span>Availability<asp:DropDownList ID="availability" AutoPostBack="true" runat="server" OnSelectedIndexChanged="availability_SelectedIndexChanged">
									
					              </asp:DropDownList>
				</div>

				<div class="flex-w flex-c-m m-tb-10">
					<div class="flex-c-m stext-106 cl6 size-105 bor4 pointer hov-btn3 trans-04 m-tb-4 js-show-search">
						<i class="icon-search cl2 m-r-6 fs-15 trans-04 zmdi zmdi-search"></i>
						<i class="icon-close-search cl2 m-r-6 fs-15 trans-04 zmdi zmdi-close dis-none"></i>
						Search
					</div>
				</div>
				
				<!-- Search product -->
				<div class="dis-none panel-search w-full p-t-10 p-b-15">
					<div class="bor8 dis-flex p-l-15">
						<button class="size-113 flex-c-m fs-16 cl2 hov-cl1 trans-04">
							<i class="zmdi zmdi-search"></i>
						</button>

						<input class="mtext-107 cl2 size-114 plh2 p-r-15" type="text" name="search-product" placeholder="Search">
					</div>	
				</div>

				
		
			</div>

			<div class="row isotope-grid" id="brandSection" runat="server" style="position: relative; height: 4595.77px;">
	
			</div>
		</div>
	</section>
	
</asp:Content>
