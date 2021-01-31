using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Alexisapp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                Label1.Text = ("dziala :)");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection stormconn = new SqlConnection("Server=tcp:alexis3-server.database.windows.net,1433;Initial Catalog=alexis3-baza;Persist Security Info=False;User ID=alexispl;Password=Aleks1999;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.InsertFullname @Fullname", stormconn);
                insert.Parameters.AddWithValue("@Fullname", TextBox1.Text);

                stormconn.Open();
                insert.ExecuteNonQuery();
                stormconn.Close();

                if (IsPostBack)
                {
                    TextBox1.Text = "";
                }
            }
        }
    }
}