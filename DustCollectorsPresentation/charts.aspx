<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationAndFooter.Master" AutoEventWireup="true" CodeBehind="charts.aspx.cs" Inherits="DustCollectorsPresentation.charts" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <asp:Chart ID="MOnthlyRegisteredUsers" Title="Monthly User Registrations" runat="server">
        <Series>
            <asp:Series Name="monthlyUsers">
              
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
                <AxisX Title="Month"></AxisX>
                <AxisY Title="Number Of Users"></AxisY>
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:Chart Width="600px" Height="800px" ID="annualRegistratinos" Title="Annual User Registrations" runat="server">
        <Series>
            <asp:Series Name="annualUsers">
              
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
                <AxisX Title="Year"></AxisX>
                <AxisY Title="Number Of Users"></AxisY>
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    	<section class="bg0 p-t-62 p-b-60">
		<div class="container">
			<div class="row">
					<div class="col-md-4 col-lg-3 p-b-80">
					<div class="side-menu">
						

						<div class="p-t-55">
							<h4 class="mtext-112 cl2 p-b-33">
								Reports
							</h4>

							<ul>
								<li class="bor18">
									<a href="chart.aspx?chart=dailyUserRegs" class="dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4">
										Daily User Registrations
									</a>
								</li>

								<li class="bor18">
									<a href="chart.aspx?chart=dailyProdSales" class="dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4">
										Daily Product Sales
									</a>
								</li>

								<li class="bor18">
									<a href="chart.aspx?chart=prodCatSales" class="dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4">
										Product Sales By Category
									</a>
								</li>

								<li class="bor18">
									<a href="chart.aspx?chart=prodsInStockTbl" class="dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4">
										Prods In Stock
									</a>
								</li>

								<li class="bor18">
									<a href="chart.aspx?chart=couponUsageTbl" class="dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4">
										Coupon Usage
									</a>
								</li>
							</ul>
						</div>

						

					</div>
				</div>
				<div class="col-md-8 col-lg-9 p-b-80">
					<div class="p-r-45 p-r-0-lg">
						<!-- item blog -->
						<div class="p-b-63">
							 <asp:Chart ID="DailyRegisteredUsers" Title="Daily User Registrations" runat="server" Width="900px" Height="500px">
								<Series>
									<asp:Series Name="users">
              
									</asp:Series>
								</Series>
								<ChartAreas>
									<asp:ChartArea Name="ChartArea1">
										<AxisX Title="Days"></AxisX>
										<AxisY Title="Number Of Users"></AxisY>
									</asp:ChartArea>
								</ChartAreas>
							</asp:Chart>

						</div>

			</div>
		</div>
	</section>	
	
</asp:Content>
