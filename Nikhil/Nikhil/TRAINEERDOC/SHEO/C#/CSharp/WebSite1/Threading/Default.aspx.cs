using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

public partial class Threading_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DoSomething();

        // creating a new thread
        Thread t = new Thread(DoSomething);
        t.Start();
        // t.Join();

        // check whether the thread has finished executing
        Response.Write(t.IsAlive + "<hr />");

        for (int i = 0; i < 100; i++)
        {
            Response.Write(" Load ");
        }

       // t.Abort();

        Response.Write("<hr />" + t.IsAlive + "<hr />");
    }

    void DoSomething()
    {
        for (int i = 0; i < 100; i++)
        {
            Response.Write(" Something ");
        }
    }


    

}


