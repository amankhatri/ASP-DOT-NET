using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace _20_VirtualPath_to_PhysicalPath_using_MapPath.Categories.Electronics
{
    public partial class PageInElectronicsFolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DS.ReadXml(Server.MapPath("~/Data/Countries/Countries.xml"));
            DropDownList1.DataTextField = "CountryName";
            DropDownList1.DataValueField = "CountryId";
            DropDownList1.DataSource = DS;
            DropDownList1.DataBind();
        }
    }
}