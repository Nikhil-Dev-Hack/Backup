using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading.Tasks;

public partial class Threading_Pooling_Default : System.Web.UI.Page
{
    // NO Thread pool

    // on an average a new thread occupies 1 MB of system memory and few hundred microseconds to organize .
    // threadpool cut this overhead by sharing and recycling threads that allows multithreading to be applied
    // at a granular level without affecting the performance
    
    // Thread pooling using Task class
    protected void Page_Load(object sender, EventArgs e)
    {
        Task t = Task.Factory.StartNew(DoSomething);
        Task tt = Task.Factory.StartNew(DoSomething);
        Response.Write("Page load: " + DateTime.Now + "<br />");
    }

    void DoSomething()
    {
        Response.Write("<br />Something is being done." + DateTime.Now);
    }
}