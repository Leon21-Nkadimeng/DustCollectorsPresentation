<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="deliveryAddresses.aspx.cs" Inherits="DustCollectorsPresentation.deliveryAddresses" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Addresses</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form class="bg0 p-t-75 p-b-85">
			
		<div class="container">
			<div class="row">
				<div class="col-lg-10 col-xl-7 m-lr-auto m-b-50">
					<div class="m-l-25 m-r--38 m-lr-0-xl">
						<h4>Address Book</h4>
						<div class="wrap-table-shopping-cart"  id="deliveryAddressesSection" runat="server">
							
						</div>
					</div>
				</div>
			
		</div>
		
		</div>
        </form>
	
</asp:Content>
