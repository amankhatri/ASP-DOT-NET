using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _15_Command_Event_of_Button_Control
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //programmatic association of aspx to event handlers using Delegates,
            /*EventHandler is a delgate now event handler knows that it has to call Button1_click 
             method which is an event handler. */
            Button1.Click += new EventHandler(Button1_Click);
            Button1.Command += new CommandEventHandler(Button1_Command);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button Click Event" + "<br />");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Response.Write("Button Command Event" + "<br />");
        }
    }
}