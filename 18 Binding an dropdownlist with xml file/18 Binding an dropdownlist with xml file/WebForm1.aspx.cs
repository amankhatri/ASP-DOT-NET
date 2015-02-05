using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
/*just like using database for storing data we can also use xml to store some amount of tata
 
 * ReadXml() method of the DataSet object can be used, to read the data from the XML file into a dataset.
 * 
 * Server.MapPath() method return the physical path for a given virtual path.
 * 
 * To insert ListItem at a specific location use Insert() method
 * 
 * we have to add all the names of the countries India, US, Australia and UK to the drop downlist and
 * we also have to display an addition item "Select", which is not in xml file, to the dropdownlist.
 
 */
namespace _18_Binding_an_dropdownlist_with_xml_file
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*To read a xml file, the easiest way is to use Dataset object*/
            DataSet DS = new DataSet();
            /*using this dataset object we can call readxml file, all this data is now in DS object by using this*/
           // DS.ReadXml("Contries.xml");
            /*how ever we should also specify the path , that is the relative path of the xml file which
             can be mapped using server.mappath method*/
            String PhysicalPath = Server.MapPath("Countries.xml");
            DS.ReadXml(PhysicalPath);
            /*we also have to set the datatext property and data value property for dropdownlist*/
            DropDownList1.DataTextField = "CountryName";
            DropDownList1.DataValueField = "CountryId";
            /*we set the data source */
            DropDownList1.DataSource = DS;
            /*we bind the data*/
            DropDownList1.DataBind();
            /*A dropdownllist is a collection of ListItem, so we can create a listItem object */
            ListItem li = new ListItem("Select", "-1");
            /*we use -1 as a value because it denotes that useer didn't select anything*/
            /*now we can add the item in the DropDownList, however this method adds the element in the end
             DropDownList1.Items.Add(li); so we will use DropdownList1.Items.insert because then we can specify
             where to add item, that is on what index*/
            DropDownList1.Items.Insert(0, li);



        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}