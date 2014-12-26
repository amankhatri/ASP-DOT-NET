using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _14_Button_LinkButton_and_ImageButton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Submit Button Clicked");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("Link Button Clicked");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("Image Button Clicked");
        }
    }
}