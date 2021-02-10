using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleBAL;
using SampleBO;

public partial class n_tier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindRecords();
        }
    }

    /// <summary>
    /// Binds the records.
    /// </summary>
    private void BindRecords()
    {
        DataTable table = new SampleBAL.DemoDatabaseBAL().GetData();
        GridView1.DataSource = table;
        GridView1.DataBind();
        
    }
}