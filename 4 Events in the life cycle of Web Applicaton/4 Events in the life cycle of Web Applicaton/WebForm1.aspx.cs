using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4_Events_in_the_life_cycle_of_Web_Applicaton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number of Applications: " + Application["TotalApplications"]);
            Response.Write("<br/>");
            Response.Write("Number of Sessions: " + Application["TotalUserSessions"]);
        }
    }
}