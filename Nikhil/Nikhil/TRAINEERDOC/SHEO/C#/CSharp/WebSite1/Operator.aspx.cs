using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Operator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a = 5;
        int b = 10;

        string sa = "ASP.";
        string sb = "NET";


        Response.Write(a + b);
        
        Response.Write("<hr />");

        Response.Write(sa + sb);


        Response.Write("<hr />");

        string myName = "Sheo";

        string myAddress = myName.Equals("Sheo") ? "India" : "USA";

        //if (myName.Equals("Sheo"))
        //{
        //    myAddress = "India";
        //}
        //else
        //{
        //    myAddress = "USA";
        //}

        Response.Write(myAddress);
    }

    // MODIFIERS
    // public = anybody can access
    // private = used inside the class only
    // internal = used inside the assembly only
    // protected = inside the class and in inheritence hierarcy
    // internal protected = internal + protected

    public class Person
    {

    }
}