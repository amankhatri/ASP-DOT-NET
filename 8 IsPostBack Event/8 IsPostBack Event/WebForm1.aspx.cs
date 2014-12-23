using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _8_IsPostBack_Event
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCityDropDownList();
            }
            
        }
        public void LoadCityDropDownList()
        {
            ListItem LI1 = new ListItem("London");
            DropDownList1.Items.Add(LI1);
            ListItem LI2 = new ListItem("Sydney");
            DropDownList1.Items.Add(LI2);
            ListItem LI3 = new ListItem("Mumbai");
            DropDownList1.Items.Add(LI3);
            ListItem LI4 = new ListItem("New York");
            DropDownList1.Items.Add(LI4);

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}