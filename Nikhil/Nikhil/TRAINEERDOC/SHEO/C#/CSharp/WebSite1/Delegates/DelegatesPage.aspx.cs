using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DelegatesPage : System.Web.UI.Page
{
    delegate int Add(int x);

    protected void Page_Load(object sender, EventArgs e)
    {
        Add a = Sum;

        Response.Write(a(6).ToString());
        Response.Write("<br />");

        a = Minus;
        Response.Write(a(6).ToString());
    }

    int Sum(int a)
    {
        return a + a;
    }

    int Minus(int b)
    {
        return b - b;
    }
}