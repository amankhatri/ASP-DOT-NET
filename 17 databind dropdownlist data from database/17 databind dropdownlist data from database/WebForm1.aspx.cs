using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace _17_databind_dropdownlist_data_from_database
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*to read the connection string from web.config file we use configuration manager class and 
                 this is how it goes*/
                /*ConfigurationManager.ConnectionString[name of the connection in web.config file].ConnectionString (get 
                 the connection string)*/
                String cs = ConfigurationManager.ConnectionStrings["DB_L17ConnectionString"].ConnectionString;
                /*now we create a sql connection , and we have to remember to open it, read it and to close it. 
                 however if we use a block that is {} we won't have to worry about closing the connection*/
                using (SqlConnection con = new SqlConnection(cs))
                { /*this is the connection block and as soon as this object dies, the connection will be closed*/
                    SqlCommand cmd = new SqlCommand("Select CityId, CityName, Country from tblCity", con);
                    /*open the connection*/
                    con.Open();
                    /*now we have to execute the command, if you take your mouse over ExecuteReader() we can 
                     see that it returns sqldataReader object, which we can set as datasource of dropdown*/
                    DropDownList1.DataSource = cmd.ExecuteReader(); //this just returns the object
                    /*so we can dropdownlist to display the text or the value in the table, we can do that using
                     DataTextField or DataValueField properties of DropDownList. 
                     These two properties can be set either in a code or in HTML. Make sure DataTextField and DataValue Field Properties are set
                     befor  databind() method. 
                     DataText field is something that user sees, and datavalue is the the value it is associate with
                     which we can use to store in database, in our case cityId can be the value*/
                    DropDownList1.DataTextField = "CityName"; //we can set it in html too
                    DropDownList1.DataValueField = "CityId"; //we can set it in html too
                    /*after this we can bound the data to dropdownlist*/
                    DropDownList1.DataBind();

                };
            }
            



        }
    }
}