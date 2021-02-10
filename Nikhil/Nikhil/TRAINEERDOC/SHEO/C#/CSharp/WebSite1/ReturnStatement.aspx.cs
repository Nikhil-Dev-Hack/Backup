using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReturnStatement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = "Sheo";

        Response.Write(s);

        return;

        string j = "fdsaf";

        Response.Write(j);
    }
}