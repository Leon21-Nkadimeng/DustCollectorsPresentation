<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="personalDetails.aspx.cs" Inherits="DustCollectorsPresentation.personalDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="tab-content p-t-43">
		<div class="container">
			<div class="row">
				<div class="col-sm-10 col-md-8 col-lg-6 m-lr-auto">
					<div class="p-b-30 m-lr-15-sm">
						<form class="w-full">
							<h5 class="mtext-108 cl2 p-b-7">
							Your personal details
							</h5>
						<div class="row p-b-25">
							<div class="col-sm-6 p-b-5">
								<label class="stext-102 cl3" for="name">First Name</label>
								<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtFirstName" runat="server" type="text" name="name"></asp:TextBox>
							</div>

							<div class="col-sm-6 p-b-5">
								<label class="stext-102 cl3" for="email">Last Name</label>
							
								<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtLastName" runat="server" type="text" name="lastname"></asp:TextBox>
							</div>
						</div>
						<div class="row p-b-25">
							<div class="col-sm-6 p-b-5">
								<label class="stext-102 cl3" for="name">Email Address</label>
								
								<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtEmailAddress" runat="server" type="email" name="email"></asp:TextBox>
							</div>

							<div class="col-sm-6 p-b-5">
								<label class="stext-102 cl3" for="email">Phone Number</label>
								<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtPhoneNumber" runat="server" type="phoneNumber" name="phoneNumber"></asp:TextBox>
							</div>
						</div>
							<div class="row p-b-5">
								<div class="col-sm-6" runat="server">
									<asp:Label ID="lblStatus" runat="server" Text=""  ></asp:Label>
								
								</div>
								
							</div>
						<div class="row p-b-25">
							<div class="col-sm-6 p-b-5">
								<asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" OnClick="btnSaveChanges_Click" />
							</div>

							
						</div>
						
						
						</form>
						</div>
					</div>
				</div>
		</div>
	</div>
</asp:Content>
