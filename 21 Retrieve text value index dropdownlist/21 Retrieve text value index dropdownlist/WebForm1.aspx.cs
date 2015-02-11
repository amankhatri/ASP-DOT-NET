using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21_Retrieve_text_value_index_dropdownlist
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*Default Selection in dropdownLIst. The default collection should always occur in if condition
                 because if it is a post back it will again display the same condition*/
                DropDownList1.SelectedIndex = 1;
                /*or you can do DropDownList1.SelectedValue = "1"*/
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "-1")
            {
                Response.Write("Please Make a selection");
            }
            else{
                Response.Write("Text " + DropDownList1.SelectedItem.Text+ " <br/>");
                Response.Write("Value " + DropDownList1.SelectedItem.Value+ " <br/>");
                Response.Write("ID or Index " + DropDownList1.SelectedIndex+ " <br/>");
               
            }

        }
    }
}