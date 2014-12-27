using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _15_Command_Event_of_Button_Control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        //This is event handler
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button Click Event" + "<br />");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Response.Write(" Button Command Event" + "<br />");
        }
    }
}