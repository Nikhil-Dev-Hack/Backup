using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

public partial class Threading_JoiningThread : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // DoSomething();

        // creating a new thread
               

        Thread t = new Thread(DoSomething);
        t.Start();

        // do some other work from other thread in between

        t.Join(); // waits for this thread to complete then proceed the execution

        // check whether the thread has finished executing
        Response.Write("<hr />" + t.IsAlive + "<hr />");

        for (int i = 0; i < 100; i++)
        {
            Response.Write(" Load ");
        }
       
        Response.Write("<hr />" + t.IsAlive + "<hr />");
    }

    void DoSomething()
    {
        // throw new ApplicationException("Some error");
        
        for (int i = 0; i < 100; i++)
        {
            Response.Write(" Something " + i + "<br />");
        }
    }
}