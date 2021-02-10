using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SwitchStatement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string department = string.Empty;
        int id = 7;

        switch (id)
        {
            case 1 :
                department = "Science 1";
                break;
            case 2:
                department = "Science 2";
                break;
            case 3:
                department = "Science 3";
                break;
            case 4:
                department = "Science 4";
                break;
            case 5:
                department = "Science 5";
                break;
            case 6:
                department = "Science 6";
                break;
            default:
                department = "Arts";
                break;
        }

        Response.Write(department);
        Response.Write("<hr />");

        id = 5;

        switch (id)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                department = "Science";
                // fdasfds
                // fasdfdsa
                break;
            case 6:
                department = "Science 6";
                break;
            default:
                department = "Arts";
                break;
        }

        Response.Write(department);

    }
}