using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _10_TextBox_Control
{
    public partial class Webform1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Namaste" + TextBox1.Text);
        }
    }
}
