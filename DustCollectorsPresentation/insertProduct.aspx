<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="insertProduct.aspx.cs" Inherits="DustCollectorsPresentation.insertProduct" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Insert Product</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container" style="margin-bottom:50px;">
		<div class="bor10 m-t-50 p-t-43 p-b-40">
			<div class="row">	
				<div class="col-lg-9  m-lr-auto">
					<div class="m-l-25 m-r--38 m-lr-0-xl">
						<form class="w-full bg0 p-t-75 p-b-85">
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<h3>Shoe Information</h3>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Name</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtName" AutoPostBack="true" runat="server" type="text" name="name"></asp:TextBox>
								</div>
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="email">Selct A Brand</label></b>
									<asp:DropDownList  class="size-111 bor8 stext-102 cl2 p-lr-20" ID="brandsList" EnableViewState="true" runat="server">

									</asp:DropDownList>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Select A category</label></b>
									<asp:DropDownList class="size-111 bor8 stext-102 cl2 p-lr-20" ID="categoriesList" EnableViewState="true"  runat="server">

									</asp:DropDownList>
								</div>

								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="email">Main Image URL</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtMainImgURl"  runat="server" type="mainIMg" name="mainIMG" TextMode="Url"></asp:TextBox>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-12 p-b-5">
									<b><label class="stext-102 cl3" for="email">Description</label></b>
									<asp:TextBox class="size-110 bor8 stext-102 cl2 p-lr-20 p-tb-10" id="txtDescription"  runat="server" TextMode="MultiLine"></asp:TextBox>
									
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="email">Price (In Rands)</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtPrice"  runat="server" ></asp:TextBox>
								</div>
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Select A Colourway</label></b>
									<asp:DropDownList class="size-111 bor8 stext-102 cl2 p-lr-20" ID="colourwayList" EnableViewState="true" runat="server">

									</asp:DropDownList>
								</div>
							</div>
							<div class="row p-b-25">
								

								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="email">Is Available</label></b>
									<asp:CheckBox ID="isAvailable" runat="server" />
								</div>
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Select A Gender Category</label></b>
									<asp:DropDownList class="size-111 bor8 stext-102 cl2 p-lr-20" ID="gendersList"  runat="server">

									</asp:DropDownList>
								</div>
							</div>
							<div class="row p-b-5">
								<div class="col-sm-12 m-b-50">
									
										<div class="wrap-table-shopping-cart">
											<asp:Table class="table-shopping-cart" ID="shoeSizesTbl" runat="server">
									<asp:TableHeaderRow class="table_head" ID="tblHeaderRow" runat="server">
										<asp:TableHeaderCell class="column-1">Shoe Size</asp:TableHeaderCell>
										<asp:TableHeaderCell class="column-1">System</asp:TableHeaderCell>
										
										<asp:TableHeaderCell class="column-1">In Stock</asp:TableHeaderCell>
										<asp:TableHeaderCell class="column-1">Is Available</asp:TableHeaderCell>
										<asp:TableHeaderCell class="column-1">
										<asp:Button ID="btnNewSize" OnClick="btnNewSize_Click" runat="server" Text="New Size" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10"/>									</asp:TableHeaderCell>
									</asp:TableHeaderRow>
									<asp:TableRow ID="newSizeRec" runat="server" Visible="false">
										<asp:TableHeaderCell class="column-1">
											<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtShoeSizeTag"  runat="server"></asp:TextBox>
										</asp:TableHeaderCell>
										<asp:TableHeaderCell class="column-1">
											<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtShoeSizeSystem"  runat="server"></asp:TextBox>
										</asp:TableHeaderCell>
										<asp:TableHeaderCell class="column-1">
											<asp:TextBox ID="txtAmountInStock"  runat="server" class="size-111 bor8 stext-102 cl2 p-lr-20"></asp:TextBox>
										</asp:TableHeaderCell>
										<asp:TableHeaderCell class="column-1">
											<asp:CheckBox ID="isShoeSizeAvailable" runat="server" />
										</asp:TableHeaderCell>
										<asp:TableHeaderCell class="column-1">
											<asp:Button ID="btnDone" OnClick="btnDone_Click" runat="server" Text="Done" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10"/>
										</asp:TableHeaderCell>
									</asp:TableRow>
									
								

								</asp:Table>
									
										</div>
									
								</div>
								</div>
							
							</div>
							<div class="row p-b-25" id="statusSection" runat="server" visible="false">
								<div class="col-12 p-b-5">
									<asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-25">
									<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" />
							
								</div>
							</div>
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>
	
		
</asp:Content>
