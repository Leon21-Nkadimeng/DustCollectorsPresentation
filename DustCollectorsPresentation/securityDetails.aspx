<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="securityDetails.aspx.cs" Inherits="DustCollectorsPresentation.securityDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tab-content p-t-43">
		<div class="container">
			<div class="row">
				<div class="col-sm-10 col-md-8 col-lg-6 m-lr-auto">
					<div class="p-b-30 m-lr-15-sm">
						<form>
							<h5 class="mtext-108 cl2 p-b-7">
							Create A New Password
							</h5>
								<b><label class="stext-102 cl3" for="name">Your Current Password</label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
						
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtCurrentPassword" runat="server" type="password" name="password" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>
							<b><label class="stext-102 cl3" for="name">Your New Password</label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtNewPassword" runat="server" type="password" name="password" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>
							<b><label class="stext-102 cl3" for="name">Confirm Your New Password</label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtConfirmNewPassword" runat="server" type="password" name="password" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>
						<div class="bor8 m-b-20 how-pos4-parent">
							<asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
						</div>
				
						<asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes" class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" OnClick="btnSaveChanges_Click" />
						
						</form>
						</div>
					</div>
				</div>
		</div>
	</div>

</asp:Content>
