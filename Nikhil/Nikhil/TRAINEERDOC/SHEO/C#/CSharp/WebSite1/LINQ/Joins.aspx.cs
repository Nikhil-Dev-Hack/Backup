using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using DemoDatabaseModel;

public partial class LINQ_Joins : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindTheGrid();
        }
    }

    private void BindTheGrid()
    {
        using (DemoDatabaseDB db = new DemoDatabaseDB())
        {
            var listP = db.PersonalDetails;
            var listF = db.Files;

            var data = from p in listP
                       join f in listF
                       on p.AutoId equals f.PersonalDetailsId
                       where p.FirstName.Contains("S")
                       select new
                       {                           
                           f.FileName,
                           p.Active,
                           p.Age,
                           p.AutoId,
                           p.FirstName,
                           p.LastName
                       };

            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}