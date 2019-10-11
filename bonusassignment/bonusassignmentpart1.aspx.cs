using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonusassignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    quadrantsummary.InnerHtml = "";
                    int quadrantFirstInput = Convert.ToInt32(quadrantfirstinput.Text);
                    int quadrantSecondInput = Convert.ToInt32(quadrantsecondinput.Text);
                    //check values for first quadrant
                    if (quadrantFirstInput > 0 && quadrantSecondInput > 0)
                    {
                        quadrantsummary.InnerHtml = "Point lies in first quadrant!";
                    }
                    //check values for second quadrant
                    else if (quadrantFirstInput < 0 && quadrantSecondInput > 0)
                    {
                        quadrantsummary.InnerHtml = "Point lies in second quadrant!";
                    }

                    //check values for third quadrant
                    else if (quadrantFirstInput < 0 && quadrantSecondInput < 0)
                    {
                        quadrantsummary.InnerHtml = "Point lies in third quadrant";
                    }
                    //check values for fourth quadrant
                    else if (quadrantFirstInput > 0 && quadrantSecondInput < 0)
                    {
                        quadrantsummary.InnerHtml = "Point lies in fourth quadrant";
                    }

                }
            }
        }
        protected void quadrantvalidate(object sender, ServerValidateEventArgs e)
        {
            int quadrantinput = Convert.ToInt32(e.Value);
            if (quadrantinput == 0)
            {
                e.IsValid = false;
            }
            else
            {
                //quadrantsummary.InnerHtml = " ";
                e.IsValid = true;
            }

        }
    }
}