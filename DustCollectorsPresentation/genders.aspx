<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="genders.aspx.cs" Inherits="DustCollectorsPresentation.genders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Gender Categories</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container" style="margin-bottom:50px;">
		<div class="bor10 m-t-50 p-t-43 p-b-40">
			<div class="row">	
				<div class="col-lg-9  m-lr-auto">
					<div class="m-l-25 m-r--38 m-lr-0-xl">
						<form class="w-full bg0 p-t-75 p-b-85">
							<div class="row p-b-5">
								<div class="col-sm-12 m-b-50">
									<div class="wrap-table-shopping-cart">
										<asp:Table class="table-shopping-cart" ID="shoeSizesTbl" runat="server">
											<asp:TableHeaderRow class="table_head" ID="tblHeaderRow" runat="server">
												<asp:TableHeaderCell class="column-1">Id</asp:TableHeaderCell>
												<asp:TableHeaderCell class="column-1">Name</asp:TableHeaderCell>
												<asp:TableHeaderCell class="column-1">Age Group</asp:TableHeaderCell>
												<asp:TableHeaderCell class="column-1">
													<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" class="flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10"/></asp:TableHeaderCell>
											</asp:TableHeaderRow>
											
										</asp:Table>
									</div>
								</div>
							</div>
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
