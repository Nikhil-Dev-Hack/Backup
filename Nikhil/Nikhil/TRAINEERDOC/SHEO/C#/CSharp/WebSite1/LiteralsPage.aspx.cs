using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LiteralsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var myName = "Sheo\nNarayan";
        Response.Write("<p>" + myName + "</p>");
        myName = "Sheo\tNarayan";
        Response.Write("<p>" + myName + "</p>");
    }
}