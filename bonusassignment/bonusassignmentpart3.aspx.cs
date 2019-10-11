using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonusassignment
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    summarytickets.InnerHtml = "";
                    //initializing my variables 
                    float ticketcost = 0.25F;
                    int TicketsOrdered = Convert.ToInt32(ticketsordered.Text);
                    //variable for holding bundled group value
                    int bundled = 0;

                    for (int i = 1; i <= TicketsOrdered; i++)
                    {
                        //checking first group
                        //how do we know how many tickets they ordered
                        if (TicketsOrdered <= 50)
                        {
                            summarytickets.InnerHtml += "You received a bundle of 1! That's " + i.ToString() + " ticket(s)<br>";
                            bundled = 1;
                        }


                    }

                    for (int i = 2; i <= TicketsOrdered; i += 2)
                    {

                        if (TicketsOrdered >= 51 && TicketsOrdered <= 150)
                        {
                            summarytickets.InnerHtml += "You received a bundle of 2! That's " + i.ToString() + " ticket(s)<br>";
                            bundled = 2;
                        }

                    }
                    //if (TicketsOrdered % 2 == 1)
                    //{
                    //    summarytickets.InnerHtml += "Your leftover is 1 ticket(s),That's " + TicketsOrdered.ToString() + " tickets<br>";
                    //}

                    for (int i = 3; i <= TicketsOrdered; i += 3)
                    {

                        if (TicketsOrdered >= 151 && TicketsOrdered <= 300)
                        {
                            summarytickets.InnerHtml += "You received a bundle of 3! That's " + i.ToString() + " ticket(s)<br>";
                            bundled = 3;
                        }

                    }
                    //if (TicketsOrdered % 3 == 1) 
                    //{
                    //    summarytickets.InnerHtml += "Your leftover is 1 ticket(s),That's " + TicketsOrdered.ToString() + " tickets<br>";
                    //}
                    //else if(TicketsOrdered % 3 == 2)
                    //{
                    //    summarytickets.InnerHtml += "Your leftover is 2 ticket(s),That's " + TicketsOrdered.ToString() + " tickets<br>";
                    //}

                    for (int i = 5; i <= TicketsOrdered; i += 5)
                    {

                        if (TicketsOrdered >= 301)
                        {
                            summarytickets.InnerHtml += "You received a bundle of 5! That's " + i.ToString() + " ticket(s)<br>";
                            bundled = 5;
                        }

                    }
                    //how do we know the left over? i assigned the variable bundled 
                    //if total number of tickets divided by bundled number is not zero 
                    //if there are leftover tickets
                    if (TicketsOrdered % bundled != 0)
                    {
                        //then if is not zero what are the possible values
                        if (TicketsOrdered % bundled == 1)
                        {
                            summarytickets.InnerHtml += "Your leftover is 1 ticket(s).That’s" + TicketsOrdered.ToString() + " ticket(s)!<br>";
                        }
                        else if (TicketsOrdered % bundled == 2)
                        {
                            summarytickets.InnerHtml += "Your leftover is 2 ticket(s).That’s" + TicketsOrdered.ToString() + " ticket(s)!<br>";
                        }
                        else if (TicketsOrdered % bundled == 3)
                        {
                            summarytickets.InnerHtml += "Your leftover is 3 ticket(s).That’s" + TicketsOrdered.ToString() + " ticket(s)!<br>";
                        }
                        else if (TicketsOrdered % bundled == 4)
                        {
                            summarytickets.InnerHtml += "Your leftover is 4 ticket(s).That’s" + TicketsOrdered.ToString() + " ticket(s)!<br>";
                        }

                    }

                    summarytickets.InnerHtml += "Your total ticket(s) is " + TicketsOrdered.ToString() + " and your total cost is $" + (ticketcost * TicketsOrdered).ToString() + "cad.<br>";


                }

            }
        }
    }
}