using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_ViewState_SessionState_ApplicationState
{
    public partial class SessionState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Clicks"] == null)
                {
                    Session["Clicks"] = 0;
                }
                TextBox1.Text = Session["Clicks"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ((int)Session["Clicks"] + 1).ToString();
            Session["Clicks"] = Convert.ToInt32(TextBox1.Text);

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}