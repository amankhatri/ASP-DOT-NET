using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_ViewState_SessionState_ApplicationState
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Clicks"] == null)
                {
                    ViewState["Clicks"] = 0;
                }
                TextBox1.Text = ViewState["Clicks"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ((int)ViewState["Clicks"] + 1).ToString();
            ViewState["Clicks"] = Convert.ToInt32(TextBox1.Text);

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}