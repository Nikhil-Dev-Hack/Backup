using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

public partial class Threading_Pooling_QueueUserWorkitem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // noraml codes
        Response.Write("<br />" + DateTime.Now + "<br />");

        // now add the methods into the pool
        ThreadPool.QueueUserWorkItem(SomethingWithParameter, "My paramtere value");
        ThreadPool.QueueUserWorkItem(SomethingWithParameter); // parameter passing is optional
        
        // or this way, both are fine
        ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(SomethingWithParameter));


        Response.Write("<br />" + DateTime.Now + "<br />");
    }

    // this method must accept a parameter
    void SomethingWithParameter(object data)
    {
        Response.Write("<p>Something with parameter :" + data + " - "+ DateTime.Now.Ticks + "</p>");
    }
}