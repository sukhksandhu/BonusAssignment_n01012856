using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonusassignment
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    workdaysummary.InnerHtml = "";
                    int day = 0;
                    //counting for oct days 1 to 31
                    //how we can print oct month 
                    while (day < 31)
                    {
                        //how we can go for days of week through list 
                        foreach (ListItem workday_selection in workdays_selection.Items)
                        {
                            // day <=31 is stopping the code to go for extra days left in week after oct 31 
                            if (day <= 31 && day > 0)// day >0 means we are not printing monday which is day 0 
                            {
                                //how to check if some day is selected
                                if (workday_selection.Selected == true)
                                {
                                    //starting the code from tuesday as oct 1 
                                    workdaysummary.InnerHtml += "Oct " + day + " is a " + workday_selection.Text + "! Time to work...<br>";

                                }
                                else
                                {

                                    workdaysummary.InnerHtml += "Oct " + day + " is a " + workday_selection.Text + "! Time to have have fun!<br>";

                                }
                            }
                            day += 1;
                        }
                    }

                }
            }
        }
    }
}