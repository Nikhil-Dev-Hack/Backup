using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ExtensionMethod : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Class1 c1 = new Class1();

        var s = c1.ToCustomString("Sheo");
        
        Response.Write(s);

        Response.Write(c1.ToString("Class1"));
    }
}