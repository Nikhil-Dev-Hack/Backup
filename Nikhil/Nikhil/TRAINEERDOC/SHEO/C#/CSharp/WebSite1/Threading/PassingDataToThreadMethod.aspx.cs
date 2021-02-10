using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

public partial class Threading_PassingDataToThreadMethod : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string someMessage = "This is the message being passed from the threa method.";
        int anyNumber = 125;

        Thread t = new Thread(() => Something(someMessage, anyNumber));
        t.Start();

        Response.Write("<p>From page load</p>");

        // Something("Fdsaf", 50);
    }

    void Something(string message, int number)
    {
        Response.Write(message + " " + number);
    }
}