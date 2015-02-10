using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _19_VirtualPath_to_PhysicalPath_using_MapPath.Categories.Electronics
{
    public partial class PageInElectronicsFolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*This opens the default path to page in Electronics folder, . represents current directory*/
            Response.Write(Server.MapPath(".") + "<br />");

            /*This opens the default path to page in Electronics folder, .. represents directory above the current directory*/
            Response.Write(Server.MapPath("..") + "<br />");

            /*To get to the root directories, there are two ways
             1) to use ~ char*/
            Response.Write(Server.MapPath("~") + "<br />");
            /*2) Another way to get to root directory if we use ../..*/
            Response.Write(Server.MapPath("~") + "<br />");
        }
    }
}