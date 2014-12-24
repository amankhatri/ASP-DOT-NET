using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _11_Radio_Button_Control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Male Radio Button Selection changed");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
            {
                Response.Write("Male Button Checked" + "<br />");
            }
            if (FemaleRadioButton.Checked)
            {
                Response.Write("Female Button Checked" + "<br />");
            }
            if (UnknownRadioButton.Checked)
            {
                Response.Write("Unknown Gender Button Checked" + "<br />");
            }
        }
    }
}