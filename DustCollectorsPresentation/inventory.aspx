<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="inventory.aspx.cs" Inherits="DustCollectorsPresentation.prodDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Products</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<!-- Products go here >> -->
	<section class="bg0 p-t-23 p-b-140">
		<div class="container">
			<div class="p-b-10">
				<h3 class="ltext-103 cl5">Inventory</h3>
			</div>
			<div clas5s="flex-w flex-sb-m p-b-52">
				
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
									<asp:Button ID="btnSortByPriceAsc"  runat="server" Text="Price: Low to High" class=" filter-linkstext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5 how-active1  stext-106 trans-04"/>
									
								</li>

								<li class="p-b-6">
									<asp:Button ID="btnSortByPriceDesc"  runat="server" Text="Price: High to Low" class=" filter-linkstext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5 how-active1  stext-106 trans-04"/>
								</li>
							</ul>
						</div>

						<div class="filter-col2 p-r-15 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Price
							</div>

							<ul>
								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04 filter-link-active">
										All
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										$0.00 - $50.00
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										$50.00 - $100.00
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										$100.00 - $150.00
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										$150.00 - $200.00
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										$200.00+
									</a>
								</li>
							</ul>
						</div>

						<div class="filter-col3 p-r-15 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Color
							</div>

							<ul>
								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #222;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										Black
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #4272d7;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04 filter-link-active">
										Blue
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #b3b3b3;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										Grey
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #00ad5f;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										Green
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #fa4251;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										Red
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #aaa;">
										<i class="zmdi zmdi-circle-o"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										White
									</a>
								</li>
							</ul>
						</div>

						<div class="filter-col4 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Availability
							</div>

							<div class="flex-w p-t-4 m-r--5">
								<asp:DropDownList ID="availability" runat="server">
									
								</asp:DropDownList>
							</div>
							<ul>
								<li class="p-b-6">
									<a href="inventory.aspx?availability=all" class="filter-link stext-106 trans-04 filter-link-active">
										All
									</a>
								</li>

								<li class="p-b-6">
									<a href="inventory.aspx?availability=available" class="filter-link stext-106 trans-04">
										Available
									</a>
								</li>

								<li class="p-b-6">
									<a href="inventory.aspx?availability=unavailable" class="filter-link stext-106 trans-04">
										Unavailable
									</a>
								</li>
								</ul>
						</div>
					</div>
				</div>
			</div>

			<div class="row isotope-grid" id="product_section" runat="server" style="position: relative; height: 4595.77px;">
	
			</div>
		</div>
	</section>
	
	
	
	
	
	
	
	
	<!--
	<div class="container" style="margin-bottom:50px;">
		<div class="bor10 m-t-50 p-t-43 p-b-40">
			<div class="row">	
				<div class="col-lg-20  m-lr-auto">
					
						<div class="row p-b-5">
							<div class="col-sm-20 m-b-50">	
								<div class="wrap-table-shopping-cart">
									<asp:Table class="table-shopping-cart" ID="productsTbl" runat="server">
										<asp:TableHeaderRow class="table_head" ID="tblHeaderRow" runat="server">
											<asp:TableHeaderCell class="column-1">Image</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">Name</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">Brand</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">Price</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">Category</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">Gender</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">Date Added</asp:TableHeaderCell>
											<asp:TableHeaderCell class="column-1">In Stock</asp:TableHeaderCell>
											
										</asp:TableHeaderRow>
										
										
									</asp:Table>	
								</div>	
							</div>
						</div>
					
				</div>
			</div>
		</div>
	</div>-->
</asp:Content>
