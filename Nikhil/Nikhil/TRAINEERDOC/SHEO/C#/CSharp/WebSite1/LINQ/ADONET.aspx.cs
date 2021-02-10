using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoDatabaseModel;

public partial class LINQ_ADONET : System.Web.UI.Page
{
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindTheGrid();
        }

    }

    protected void InsertRecord(object sender, EventArgs e)
    {
        PersonalDetail p = new PersonalDetail()
        {
            Active = true,
            Age = 20,
            FirstName = "Ranjit",
            LastName = "Mahato"
        };

        using (DemoDatabaseDB db = new DemoDatabaseDB())
        {
            db.PersonalDetails.AddObject(p);
            db.SaveChanges();
        }

        lblMessage.Text = "Record added to the database successfully!";
    }

    protected void UpdateRecord(object sender, EventArgs e)
    {           

        using (DemoDatabaseDB db = new DemoDatabaseDB())
        {
            PersonalDetail p = db.PersonalDetails.Where(pp => pp.AutoId.Equals(52)).FirstOrDefault();

            p.Active = false;
            p.Age = 30;
            p.FirstName = "Ranjit modified";
            p.LastName = "Mahato modified";

            db.SaveChanges();
        }

        lblMessage.Text = "Record updated to the database successfully!";
    }

    protected void DeleteRecord(object sender, EventArgs e)
    {

        using (DemoDatabaseDB db = new DemoDatabaseDB())
        {
            PersonalDetail p = db.PersonalDetails.Where(pp => pp.AutoId.Equals(52)).FirstOrDefault();

            db.PersonalDetails.DeleteObject(p);

            db.SaveChanges();
        }

        lblMessage.Text = "Record delete from the database successfully!";
    }

    /// <summary>
    /// Binds the grid.
    /// </summary>
    private void BindTheGrid()
    {
        using (DemoDatabaseDB db = new DemoDatabaseDB())
        {
            var data = from d in db.PersonalDetails
                       where d.FirstName.Contains("S")
                       select d;

            var datas = db.PersonalDetails.OrderBy(p => p.FirstName).Take(5).Skip(2);

            GridView1.DataSource = db.PersonalDetails; //data;
            GridView1.DataBind();
        }
    }
}