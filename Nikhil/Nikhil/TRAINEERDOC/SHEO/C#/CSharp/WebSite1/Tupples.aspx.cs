using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tupples : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var tuple = GetTupple();
   
        Response.Write(tuple.Item1 +" + " + tuple.Item2 + " = " + tuple.Item3);
        Response.Write("<hr />");
        Response.Write(tuple.GetType());
    }

    private Tuple<int, int, string> GetTupple()
    {
        return Tuple.Create(50, 60, "The sum is " + 110);
    }
}