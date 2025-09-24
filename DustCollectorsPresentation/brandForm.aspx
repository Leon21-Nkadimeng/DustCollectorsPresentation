<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="brandForm.aspx.cs" Inherits="DustCollectorsPresentation.insertBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<div class="bread-crumb flex-w p-l-25 p-r-15 p-t-30 p-lr-0-lg" id="breadCrumb" runat="server">
			<a href="index.aspx" class="stext-109 cl8 hov-cl1 trans-04">
				Home
				<i class="fa fa-angle-right m-l-9 m-r-10" aria-hidden="true"></i>
			</a>
		</div>
	</div>
	<div class="container" style="margin-bottom:50px;">
		<div class="bor10 m-t-50 p-t-43 p-b-40">
			<div class="row">	
				<div class="col-lg-9  m-lr-auto">
					<div class="m-l-25 m-r--38 m-lr-0-xl">
						<form class="w-full bg0 p-t-75 p-b-85">
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<h3 id="pageTitle" runat="server">Brand Information</h3>
								</div>
							</div>
							<div class="row p-b-25" >
								<div class="col-lg-6 p-b-5" id="logoSection" runat="server">
									
								</div>

								
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Name</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtName" AutoPostBack="true" runat="server" type="text" name="name"></asp:TextBox>
								</div>
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="email">Is Active</label></b>
									<asp:CheckBox ID="isActive" runat="server" />
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-12 p-b-5">
									<b><label class="stext-102 cl3" for="name">Main Logo URL</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" id="txtMainLogo"  runat="server"></asp:TextBox>
								</div>

								
							</div>
							<div class="row p-b-25">
								<div class="col-sm-12 p-b-5">
									<b><label class="stext-102 cl3" for="name">Description</label></b>
									<asp:TextBox class="size-110 bor8 stext-102 cl2 p-lr-20 p-tb-10" id="txtDescription"  runat="server" TextMode="MultiLine"></asp:TextBox>
								</div>

								
							</div>
							<div class="row p-b-25" id="statusSection" runat="server">
								<div class="col-sm-6 p-b-5">
									<asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
								</div>
							</div>
							<div class="row p-b-25" id="submitSection" runat="server">
								<div class="col-sm-6 p-b-25">
									<asp:Button ID="btnSubmit" runat="server" Text="Submit"  class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" OnClick="btnSubmit_Click" />
									
								</div>
							</div>
							<div class="row p-b-25" id="saveChangesSection" runat="server">
								<div class="col-sm-6 p-b-25">
									<asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes"  class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" OnClick="btnSaveChanges_Click" />
									
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	
</asp:Content>
