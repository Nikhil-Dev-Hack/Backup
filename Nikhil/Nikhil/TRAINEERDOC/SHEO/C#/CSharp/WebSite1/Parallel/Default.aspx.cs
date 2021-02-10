using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parallel_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            long s = DateTime.Now.Ticks;
            //EnumerateMe();
            EnumerateMeWithOrder();
            // EnumerateMeWithOrder();
            long ee = DateTime.Now.Ticks;
            Response.Write("Time: " + (ee - s));
        }
    }

    /// <summary>
    /// Enumerates me // writes the number up and down because of AsParallel, if you remove it writes in sequence
    /// </summary>
    void EnumerateMe()
    {
        IEnumerable<int> myNumbers = Enumerable.Range(0, 10);

        var myQuery = from n in myNumbers.AsParallel().WithDegreeOfParallelism(4)
                      where n % 2 == 0
                      select n;

        foreach (int i in myQuery)
        {
            Response.Write(i.ToString() + "<br />");
        }
    }

    /// <summary>
    /// Enumerates me with order // writes the number in order even if asparallel because of AsOrdered, if you remove it writes in sequence
    /// </summary>
    void EnumerateMeWithOrder()
    {
        IEnumerable<int> myNumbers = Enumerable.Range(0, 10);
        var myQuery = from n in myNumbers.AsParallel().AsOrdered()
                      where n % 2 == 0
                      select n;
        foreach (int i in myQuery)
        {
            Response.Write(i.ToString() + "<br />");
        }
    }
}