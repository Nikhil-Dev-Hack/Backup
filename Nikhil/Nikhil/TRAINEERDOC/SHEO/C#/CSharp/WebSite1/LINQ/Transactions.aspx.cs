using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoDatabaseModel;
using System.Transactions;

public partial class LINQ_Transactions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListRecords();
        }
    }

    void ListRecords()
    {
        using (DemoDatabaseDB db = new DemoDatabaseDB())
        {
            GridView1.DataSource = db.PersonalDetails;
            GridView1.DataBind();

            GridView2.DataSource = db.Menus;
            GridView2.DataBind();
        }
    }

    protected void SaveUsingLinqWithTransaction(object sender, EventArgs e)
    {
        using (TransactionScope scope = new TransactionScope())
        {
            try
            {
                using (DemoDatabaseDB db = new DemoDatabaseDB())
                {
                    PersonalDetail p = new PersonalDetail()
                    {
                        Active = true,
                        Age = int.MaxValue,
                        FirstName = "firstnamne",
                        LastName = "lastname"
                    };
                    db.PersonalDetails.AddObject(p);
                    db.SaveChanges();

                    DemoDatabaseModel.Menu m = new DemoDatabaseModel.Menu()
                    {
                        MenuDescription = "description1",
                        MenuName = "Menu1Menu1Menu1Menu1Menu1Menu1Menu21", //Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1Menu1",
                        MenuUrl = "http://www.fundooVideo.com/",
                        ParentMenuId = 1,
                        MenuId = 127
                    };
                    
                    
                    db.Menus.AddObject(m);
                    db.SaveChanges();
                }
                scope.Complete();
            }
            catch (Exception ee)
            {
                Response.Write(ee.ToString());
            }
        }
    }
}