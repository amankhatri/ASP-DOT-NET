using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _17_DropDownList_with_data_from_database
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Connection string is the name of the database and the user name and stuff
            this connection string is then supplied to sqlconnection class
             connectionString = "data source=nameof the data base or if it is on local machine type '."; 
             * database = nameof database; user id = sa; password = password for windows authentications
             * you do 
             * connectionString = data source=nameof the data base or if it is on local machine type '."; 
             * database = nameof database; integrated security=sspi , connectionstring is key value pair"*/
             string connectionString = "data source=khatri\\mssqlserver2 ;database = DB_L17; user id=sa; password=2059794842";
            //string connectionString = "data source=.;database = DB_L17; integrated security=SSPI";
            SqlConnection conn = new SqlConnection(connectionString);
            /*or you can do SqlConnection conn = new SqlConnection()
             conn.ConnectionString = connectionString*/
            
            /*now we need sql command which we are executing , and we have to specify which connection to use*/
            SqlCommand cmd = new SqlCommand("Select CityId, CityName, Country from tblCity", conn);
            /*we need to open connection*/
            conn.Open();
            /*now we will execute the command and set it to the datasouce property of gridview*/
            GridView1.DataSource = cmd.ExecuteReader();
           // DropDownList1.DataSource = cmd.ExecuteReader();
            /*then bind the data */
            GridView1.DataBind();
          //  DropDownList1.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}