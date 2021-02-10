using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

public partial class Threading_ErrorHandling : System.Web.UI.Page
{
    // threading follows its own execution path, so a particular thread exception can't be caught in the parent thread

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            new Thread(Something).Start();
        }
        catch (Exception ex)
        {
            Response.Write("<p>Is it reaching here? " + ex.ToString() + "</p>"); // will not reach here
        }


        new Thread(Something).Start();
        Response.Write("Do something here.");


        //// In case - to catch the exception in calling method, we can do following
        //try
        //{
        //    new Thread(Something).Start();
        //}
        //catch (Exception ex)
        //{
        //    Response.Write("<p>PARENT TRY: Is it reaching here? " + ex.ToString() + "</p>"); // will not reach here
        //}


    }

    void Something()
    {
        throw new ApplicationException("this is the exception.");

        try
        {
            Response.Write("<hr />Inside Something.<hr />");
            throw new ApplicationException("<hr />this is the exception.<hr />");
        }
        catch (Exception ex)
        {
            Response.Write("Last exception: " + ex.ToString()); // will not reach here
        }
    }
}
