using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class ArrayList_ListPage : System.Web.UI.Page
{
    string _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //PopulateDataUsingTable();
            PopulateDataUsingCollection();
        }
    }


    private void PopulateDataUsingTable()
    {
        DataTable table = GetDataTable();
        
        GridView1.DataSource = table;
        GridView1.DataBind();

        
    }

    private void PopulateDataUsingCollection()
    {
        var list = GetCollectioon();

        var myData = list.Where(p => p.Age > 50);

        GridView1.DataSource = myData;
        GridView1.DataBind();

        
    }

    #region 3rd party methods

    private DataTable GetDataTable()
    {
        DataTable table = new DataTable();
        using (SqlConnection conn = new SqlConnection(_connStr))
        {
            string sql = "SELECT AutoId, FirstName, LastName, Age FROM PersonalDetails ORDER BY AutoID";
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = sql;
                cmd.Connection = conn;

                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    ad.Fill(table);
                }
            }
        }

        return table;
    }

    private List<Person> GetCollectioon()
    {
        DataTable table = new DataTable();
        using (SqlConnection conn = new SqlConnection(_connStr))
        {
            string sql = "SELECT AutoId, FirstName, LastName, Age FROM PersonalDetails ORDER BY AutoID";
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = sql;
                cmd.Connection = conn;

                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    ad.Fill(table);
                }
            }
        }

        List<Person> list = new List<Person>();
        foreach (DataRow row in table.Rows)
        {
            list.Add(new Person()
            {
                AutoId = int.Parse(row["AutoId"].ToString()),
                Age = int.Parse(row["Age"].ToString()),
                FirstName = row["FirstName"].ToString(),
                LastName = row["LastName"].ToString()
            });
        }
        return list;
    }

    #endregion 3rd party methods

}