using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ImplicitType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // implicit type data variable
        var age = 50;

        Response.Write(age.GetType());

        Response.Write("<br />");

        var myName = "Ranjit Kumar Mahato";

        Response.Write(myName.GetType());

        // int id = 0;

        var id = 50;

        int i;

        i = 60;

        
    }
}