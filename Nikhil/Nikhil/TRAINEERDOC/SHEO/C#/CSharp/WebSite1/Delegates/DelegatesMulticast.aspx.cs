using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DelegatesPage : System.Web.UI.Page
{
    // multi-cast delegates
    delegate void Add(int x);
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Add a = Sum;
        a += Minus;
        a += Multiply;

        a -= Minus;

        a(6);        
    }

    void Sum(int a)
    {
        Response.Write(a + a);
        Response.Write("<br />");
    }

    void Multiply(int a)
    {
        Response.Write("<br />");
        Response.Write(a * a);
    }

    void Minus(int b)
    {
        Response.Write(b - b);
    }
}