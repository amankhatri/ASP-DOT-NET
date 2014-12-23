using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_Server_Control_Events
{
    public partial class All_Events_Considered : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init" + "<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad" + "<br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load" + "<br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_LoadComplete" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender" + "<br/>");
        }
        protected void Page_PreRendercomplete(object sender, EventArgs e)
        {
            Response.Write("Page_PreRendercomplete" + "<br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            //we can't use response because all the processing of form was completed before this step
            // Response.Write("Page_PreRendercomplete" + "<br/>"); is of no use
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed" + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button Clicked" + "<br/>");
        }
    }
}