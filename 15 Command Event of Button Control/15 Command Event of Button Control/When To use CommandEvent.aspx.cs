using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _15_Command_Event_of_Button_Control
{
    public partial class When_To_use_CommandEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CommandButton_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":
                    OutputLabel.Text = "You Clicked Print Button";
                    break;
                case "Delete":
                    OutputLabel.Text = "You Clicked Button";
                    break;
                case "Show":
                    if (e.CommandName.ToString() == "TOP10")
                    { OutputLabel.Text = "You Clicked Show Top 10 Employees Button"; }
                    else 
                    { OutputLabel.Text = "You Clicked Show Bottom 10 Employees Button"; }
                    break;
                default:
                    OutputLabel.Text = "We don't know which button you clicked";
                    break;

            }
        }
    }
}