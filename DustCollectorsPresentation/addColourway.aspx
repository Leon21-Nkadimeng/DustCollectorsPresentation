<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="addColourway.aspx.cs" Inherits="DustCollectorsPresentation.colourways" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Colourways</title>
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
									<h3>New Colourway</h3>
								</div>
							</div>
							<div class="row p-b-25">
								<div class="col-sm-12 p-b-5">
									<b><label class="stext-102 cl3" for="name">Name</label></b>
									<asp:TextBox class="size-111 bor8 stext-102 cl2 p-lr-20" ID="txtName" AutoPostBack="true" runat="server" type="text" name="name"></asp:TextBox>
									<asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>
									<asp:Button ID="btnAdd" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10" runat="server" Text="Add Colourway" OnClick="btnAdd_Click" />
								</div>
								
								
							</div>
							
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>


</asp:Content>
