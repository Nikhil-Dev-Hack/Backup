using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IfStatement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {       

        int id = 0;
        string result = string.Empty;

        if (id == 01)
        {
            result = "Yes";
        }
        else
        {
            result = "No";
        }
        Response.Write(result + "<br />");
        // return;


        id = 12;
        
        if (id == 0)
        {
            result = "Yes";
        }
        else if (id == 1)
        {
            result = "No";
        }
        else
        {
            result = "Wrong option";
        }
        Response.Write(result);

    }
}