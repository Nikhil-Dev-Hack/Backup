using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OptionalParams : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var sum = Add(5);
        Response.Write(sum.ToString()); // 10

        Response.Write("<br />");

        var sum1 = Add(5, 11);
        Response.Write(sum1.ToString()); // 16
    }

    public int Add(int a, int b = 5)
    {
        return a + b;
    }
}