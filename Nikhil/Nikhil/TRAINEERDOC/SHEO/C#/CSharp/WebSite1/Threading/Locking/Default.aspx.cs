using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

public partial class Threading_Locking_Default : System.Web.UI.Page
{
    static int i = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        object lockerObject = new object();

        // it makes sure that multiple thread can't access the lock block simultaneously 
        lock (lockerObject)
        {
            i++;
            Response.Write("Do something " + i);

        }

        // above statement is the short form of Monitor.Enter and Monitor.Exit along wiht try finally block

        Monitor.Enter(lockerObject);
        try
        {
            i++;
            Response.Write("Do something " + i);
        }
        finally
        {
            Monitor.Exit(lockerObject);
        }
                
    }
}