<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DustCollectorsPresentation.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<title>Home</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
	<!-- Search product -->
	<div class="dis-none panel-search w-full p-t-10 p-b-15">
		<div class="bor8 dis-flex p-l-15">
			<button class="size-113 flex-c-m fs-16 cl2 hov-cl1 trans-04">
				<i class="zmdi zmdi-search"></i>
			</button>
			
			
		</div>	
	</div>

<!-- Products go here >> -->
	<section class="bg0 p-t-23 p-b-140">
		<div class="container">
			<div class="p-b-10">
				<h3 class="ltext-103 cl5">Product Overview</h3>
			</div>
			<div clas5s="flex-w flex-sb-m p-b-52">
				<div class="flex-w flex-l-m filter-tope-group m-tb-10">
			
					<button class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5 how-active1" data-filter="*">
						All Products
					</button>

					<button class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5" >
						Women
					</button>

					<button class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5" >
						Men
					</button>

					<button class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5" >
						Bag
					</button>

					<button class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5" >
						Shoes
					</button>

					<button class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5" >
						Watches
					</button>
					
				</div>

				<div class="flex-w flex-c-m m-tb-10">
					<div class="flex-c-m stext-106 cl6 size-104 bor4 pointer hov-btn3 trans-04 m-r-8 m-tb-4 js-show-filter">
						<i class="icon-filter cl2 m-r-6 fs-15 trans-04 zmdi zmdi-filter-list"></i>
						<i class="icon-close-filter cl2 m-r-6 fs-15 trans-04 zmdi zmdi-close dis-none"></i>
						 Filter
					</div>

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

				<!-- Filter -->
				<div class="dis-none panel-filter w-full p-t-10">
					<div class="wrap-filter flex-w bg6 w-full p-lr-40 p-t-27 p-lr-15-sm">
						<div class="filter-col1 p-r-15 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Sort By
							</div>

							<ul>
								
								<li class="p-b-6">
									<asp:Button ID="btnSortByPriceAsc" OnClick="btnSortByPriceAsc_Click" runat="server" Text="Price: Low to High" class=" filter-linkstext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5 how-active1  stext-106 trans-04"/>
									
								</li>

								<li class="p-b-6">
									<asp:Button ID="btnSortByPriceDesc" OnClick="btnSortByPriceDesc_Click" runat="server" Text="Price: High to Low" class=" filter-linkstext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5 how-active1  stext-106 trans-04"/>
								</li>
							</ul>
						</div>

						<div class="filter-col2 p-r-15 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Category
							</div>
							<asp:RadioButtonList ID="categories" AutoPostBack="true" runat="server" OnSelectedIndexChanged="categories_SelectedIndexChanged">
								
							</asp:RadioButtonList>
							
						</div>

						<div class="filter-col3 p-r-15 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Colourway
							</div>
							<asp:RadioButtonList ID="colourways" AutoPostBack="true" runat="server" OnSelectedIndexChanged="colourways_SelectedIndexChanged">
								
							</asp:RadioButtonList>
						</div>

					</div>
				</div>
			</div>

			<div class="row isotope-grid" id="product_section" runat="server" style="position: relative;">
	
			</div>
		</div>
	</section>




</asp:Content>
