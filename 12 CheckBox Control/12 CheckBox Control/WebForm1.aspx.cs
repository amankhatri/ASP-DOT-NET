using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace _12_CheckBox_Control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbUserChoice = new StringBuilder();
            if(GraduateCheckBox.Checked) { sbUserChoice.Append(GraduateCheckBox.Text); }
            if (PostGraduateCheckBox.Checked) { sbUserChoice.Append(PostGraduateCheckBox.Text); }
            if(DoctrateCheckBox.Checked) {sbUserChoice.Append(DoctrateCheckBox.Text);}
            Response.Write("You Selected : " + sbUserChoice.ToString() + ", ");
        }
    }
}