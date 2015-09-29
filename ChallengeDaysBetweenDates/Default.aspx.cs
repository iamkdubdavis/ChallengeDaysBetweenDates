using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int totalDays = 0;

            DateTime firstDate = firstCalendar.SelectedDate;
            int dayOne = firstDate.Day;

            DateTime secondDate = secondCalendar.SelectedDate;
            int dayTwo = secondDate.Day;

            if (dayOne > dayTwo)
                totalDays = dayOne - dayTwo;
            else
                totalDays = dayTwo - dayOne;

            resultLabel.Text = totalDays.ToString();
        }
    }
}