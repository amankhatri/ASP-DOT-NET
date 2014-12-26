using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _14_Button_LinkButton_and_ImageButton
{
    public partial class WebForm2_JavaScript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Form Submitted");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Submit Confirmed");
        }
    }
}