using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList
{
    public partial class frmDropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("Select * from tblCity", conn);
            using(conn)
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DropDownList1.DataSource = reader;
                //DropDownList1.DataTextField = "pkCity";
                //DropDownList1.DataValueField = "CityName";
                DropDownList1.DataBind();
            }
        }
    }
}