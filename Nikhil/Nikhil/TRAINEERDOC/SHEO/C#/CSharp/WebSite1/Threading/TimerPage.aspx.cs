using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consoleApp3
{ 
public partial class Threading_TimerPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Mainly used in desktop app as timer runs in the server side
        using (System.Threading.Timer t = new System.Threading.Timer(TimerTick,"active",5000,7500))
        {

        }        
    }

    void TimerTick(object myObject)
    {
        Response.Write(myObject);
    }
}
}