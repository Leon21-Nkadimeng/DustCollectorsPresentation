using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DustCollectorsPresentation
{
    public partial class NavigationAndFooter : System.Web.UI.MasterPage
    {
        private bool isSessionActive = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["SessionID"] != null && Session["UserID"] != null && Session["Username"] != null && Session["UserType"] != null)
            {
                if(Request.QueryString["isLoggedOut"] != null && Request.QueryString["isLoggedOut"].Equals("true"))
                {
                    Session.Abandon();
                    userGreeting.Visible = false;
                    userGreetingResponsive.Visible = false;
                    linkToAccountDashboard.Visible = false;
                    linkToAccountDashboardResponsive.Visible = false;
                    linkToLogin.Visible = true;
                    linkToLoginResponsive.Visible = true;
                    linkToRegister.Visible = true;
                    linkToRegisterResponsive.Visible = true;
                    logoutLink.Visible = false;
                    logoutLinkResponsive.Visible = false;
                }
                else if (Session["UserType"].Equals("customer"))
                {
                    userGreeting.Visible = true;
                    userGreeting.InnerHtml = "<span style='color: white;'> Hi "+Session["Username"]+"</span>";
                    userGreetingResponsive.InnerHtml += userGreeting.InnerHtml;
                    linkToAccountDashboard.Visible = true;
                    linkToAccountDashboardResponsive.Visible = true;
                    linkToLogin.Visible = false;
                    linkToLoginResponsive.Visible = false;
                    linkToRegister.Visible = false;
                    linkToRegisterResponsive.Visible = false;
                    logoutLink.Visible = true;
                    logoutLinkResponsive.Visible = true;
                }
            }
        }
/*
        protected void btnLogoutResponsive_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
*/
    }
}