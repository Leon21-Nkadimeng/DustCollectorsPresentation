<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="addressForm.aspx.cs" Inherits="DustCollectorsPresentation.addressForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<title>Address Form</title>
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
									<h4>
									Address
									</h4>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Recipient Name</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" required ID="txtRecipientName" runat="server" type="text" name="name"></asp:TextBox>
								</div>

								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Recipient Phone</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" required ID="txtRecipientPhone" runat="server" type="text" name="name"></asp:TextBox>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Street Address</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" required ID="txtStreetAddress" runat="server" type="text" name="name"></asp:TextBox>
								</div>

								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Complex/Building</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtComplexOrBuilding" runat="server" type="text" name="name"></asp:TextBox>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Suburb</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtSuburb" required runat="server" type="text" name="name"></asp:TextBox>
								</div>

								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="email">Select A Province</label></b>
							
									<asp:DropDownList  class="size-111 bor8 stext-102 cl2 p-lr-20" ID="provinceList" required runat="server">
										<asp:ListItem></asp:ListItem>
										<asp:ListItem>Gauteng</asp:ListItem>
										<asp:ListItem>Free State</asp:ListItem>
										<asp:ListItem>Western Cape</asp:ListItem>
										<asp:ListItem>Eastern Cape</asp:ListItem>
										<asp:ListItem>Limpopo</asp:ListItem>
										<asp:ListItem>Nothern Cape</asp:ListItem>
										<asp:ListItem>Kwa Zulu Natal</asp:ListItem>
										<asp:ListItem>North West</asp:ListItem>
										<asp:ListItem>Mpumalanga</asp:ListItem>
									</asp:DropDownList>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<b><label class="stext-102 cl3" for="name">Postal Code</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtPostalCode"  required runat="server" type="text" name="name"></asp:TextBox>
								</div>
								<div class="col-sm-6 p-b-5">
								<b><label class="stext-102 cl3" for="name">City Or Town</label></b>
								<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtCityOrTown" required runat="server" type="text" name="name"></asp:TextBox>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<asp:Label ID="lblStatus" runat="server" Text="" style="color:red;"></asp:Label>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-6 p-b-5">
									<asp:Button ID="btnSubmit" runat="server" Text="Submit" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" Visible="true" OnClick="btnSubmit_Click" />
									<asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" Visible="false" OnClick="btnSaveChanges_Click" />
								</div>
							</div>
						</form>
					</div>
				</div>
			</div>
			</div>
		</div>
</asp:Content>
