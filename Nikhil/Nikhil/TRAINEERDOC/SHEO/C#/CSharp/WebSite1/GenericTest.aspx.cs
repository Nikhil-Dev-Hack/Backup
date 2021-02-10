using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class GenericTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MyGClass<int> mG = new MyGClass<int>(55);
        Response.Write(mG.GetData());

        Response.Write("<hr />");

        MyGClass<DateTime> mD = new MyGClass<DateTime>(DateTime.Now.AddDays(354));
        Response.Write(mD.GetData());

        Response.Write("<hr />");

        MyGClassConstraint<DataTable> mGC = new MyGClassConstraint<DataTable>();
        


    }
}