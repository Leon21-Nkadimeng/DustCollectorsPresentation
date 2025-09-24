using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using DustCollectorsPresentation.ServiceReference1;
using System.Globalization;
namespace DustCollectorsPresentation
{
    public partial class charts : System.Web.UI.Page
    {
        private Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic dailyRegUsers = client.getDailyRegisteredUsers();
            if (dailyRegUsers != null)
            {
                Series regUsersSeries = DailyRegisteredUsers.Series["users"];
                foreach (RegisteredUsers u in dailyRegUsers)
                {

                    regUsersSeries.Points.AddXY(u.date.ToString("M"), u.numUsers);

                }
            }
            dynamic monthlyRegUsers = client.getMonthlyRegisteredUsers();
            if (dailyRegUsers != null)
            {
                Series regUsersSeries = MOnthlyRegisteredUsers.Series["monthlyUsers"];
                foreach (MonthlyUsers u in monthlyRegUsers)
                {

                    regUsersSeries.Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(u.Month)), u.numUsers);





                }
            }
            dynamic annualRegUsers = client.getAnnualUserRegistrations();
            if (dailyRegUsers != null)
            {
                Series regUsersSeries = annualRegistratinos.Series["annualUsers"];
                foreach (AnnualUserRegistrations u in annualRegUsers)
                {

                    regUsersSeries.Points.AddXY(u.year, u.numUsers.ToString());





                }
            }
        }
        protected void Page_Unload(object sender, EventArgs e)
        {

        }
    }
}