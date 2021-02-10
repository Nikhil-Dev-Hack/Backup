using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

public partial class Threading_ThreadSleeping : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<p>Thread started</p>");
        Response.Write(DateTime.Now.Ticks);
        Thread.Sleep(5000); // pauses the current thread for specified number of milliseconds



        Response.Write("<br />"  + DateTime.Now.Ticks);

    }
}