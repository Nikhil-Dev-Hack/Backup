using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Polymorphism : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PolyClass pc = new PolyClass();
       
        Response.Write(pc.Sum(50, 30) + "<br />");
        Response.Write(pc.Sum(3000, 5000, 5000) + "<hr />");
        
        Response.Write(pc.Multiply(50, 30));

        PolyParent pp = new PolyParent();

        Response.Write("<hr />" + pp.Multiply(20, 30));



















    }
}