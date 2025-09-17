<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="DustCollectorsPresentation.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Register</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content page -->
	<section class="bg0 p-t-104 p-b-116">
		<div class="container">
			<div class="flex-w flex-tr">
				<div class="size-210 bor10 p-lr-70 p-t-55 p-b-70 p-lr-15-lg w-full-md">
					<div>
						<h4 class="mtext-105 cl2 txt-center p-b-30">
							Register For An Account
						</h4>

						<b><asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtFirstName" runat="server" placeholder="Your First Name" type="firstName" name="firstName" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>

						<b><asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtLastName" runat="server" placeholder="Your Last Name" type="lastName" name="lastName" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>

						<b><asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtEmail" runat="server" placeholder="Your Email Address" type="email" name="email" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>

						<b><asp:Label ID="lblPhone" runat="server" Text="Phone Number"></asp:Label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtPhone" runat="server" placeholder="Your Phone Number" type="phoneNumber" name="phoneNumber" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>

						<b><asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtPassword" runat="server" placeholder="Your Password" type="password" name="password" required></asp:TextBox>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>

						<b><asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password"></asp:Label></b>
						<div class="bor8 m-b-20 how-pos4-parent">
							
							<asp:TextBox class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" ID="txtConfirmPassword" runat="server" placeholder="Confirm Your Password" type="password" name="password" required></asp:TextBox>
							
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>
						<div class="bor8 m-b-20 how-pos4-parent">
							<asp:Label ID="lblRegisterStatus" runat="server" Text="" style="color:red;"></asp:Label>
							<!--<img class="how-pos4 pointer-none" src="images/icons/icon-email.png" alt="ICON">-->
						</div>
						<asp:Button ID="btnRegister" runat="server" Text="Register" class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" OnClick="btnRegister_Click" />
						
					</div>
				</div>

				<div class="size-210 bor10 flex-w flex-col-m p-lr-93 p-tb-30 p-lr-15-lg w-full-md">
					<h4 class="mtext-105 cl2 txt-center p-b-30">
							Already have an account?
					</h4>
					<asp:Button UseSubmitBehavior="false" CausesValidation="false" ID="btnToLogin" runat="server" Text="Login Here" class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" OnClick="btnToLogin_Click" />
				
				</div>	
			</div>
		</div>
	</section>	
</asp:Content>
