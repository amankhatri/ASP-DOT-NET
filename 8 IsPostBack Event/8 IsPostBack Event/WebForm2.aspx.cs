using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _8_IsPostBack_Event
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Loading Page for the first time - is not a postback" + "<br/>");
            }
            else
            {
                Response.Write("This is a Post Back Event" + "<br/>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}