<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="DustCollectorsPresentation.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content page -->
	<section class="bg0 p-t-104 p-b-116">
		<div class="container">
			<div class="flex-w flex-tr">
				<div class="size-210 bor10 flex-w flex-col-m p-lr-93 p-tb-30 p-lr-15-lg w-full-md">
					<h4 class="mtext-105 cl2 txt-center p-b-30">
							Don't Have An Account?
					</h4>
					
					<asp:Button CausesValidation="False" ID="btnToRegister" runat="server" Text="Register Here" class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" OnClick="btnToRegister_Click" />
				</div>
				<div class="size-210 bor10 p-lr-70 p-t-55 p-b-70 p-lr-15-lg w-full-md">
					<form>
						<h4 class="mtext-105 cl2 txt-center p-b-30" id="login_title" runat="server">
							Login To Your Account
						</h4>

						<b><asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtEmail" runat="server" placeholder="Your Email Address" type="email" name="email" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>

						<b><asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
						
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtPassword" runat="server" placeholder="Your Password" type="password" name="password" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>
						
						<div class="bor8 m-b-20 how-pos4-parent">
							<asp:Label ID="lblLoginStatus" runat="server" Text="" style="color:red;"></asp:Label>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>
						<asp:Button ID="btnLogin" runat="server" Text="Login" class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" OnClick="btnLogin_Click" />
						
					</form>
				</div>

					
			</div>
		</div>
	</section>	
</asp:Content>
