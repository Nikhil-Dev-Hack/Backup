using System;
using System.Collections.Concurrent;
using System.Linq;

public partial class ConcurrenBagList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConcurrentBag<int> list = new ConcurrentBag<int>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        }

        var myList = list.OrderBy(d => d);

        foreach (int i in myList)
        {
            Response.Write(i.ToString() + "<br />");
        }
    }
}