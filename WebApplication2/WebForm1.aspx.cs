using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string CS = "data source=.; database=Sample; Integrated Security=SSPI";
            SqlConnection Con = new SqlConnection(CS);
            try
            {
                SqlCommand cmd = new SqlCommand(" select * from tblemployee", Con);
                Con.Open();
                cmd.ExecuteReader();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }

            catch { }
            finally
            {
                Con.Close();
            }

        }
    }
}