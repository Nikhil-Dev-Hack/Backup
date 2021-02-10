using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using DemoDatabaseModel;

public partial class LINQ_StoredProcedure : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void SubmitData(object sender, EventArgs e)
    {
        int id = 0;
        int.TryParse(txtAutoId.Text.Trim(), out id);

        if (!id.Equals(0))
        {
            using (DemoDatabaseDB db = new DemoDatabaseDB())
            {
                

                var data = db.GetRecords(id);
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }
        else
        {
            lblMessage.Text = "Please enter numeric value only !";
        }
    }

}