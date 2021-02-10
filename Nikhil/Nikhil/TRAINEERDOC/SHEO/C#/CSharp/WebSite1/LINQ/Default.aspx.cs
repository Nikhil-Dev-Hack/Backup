using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LINQ_Default : System.Web.UI.Page
{
    // Language INtegrated Query
    // LINQ

    protected void Page_Load(object sender, EventArgs e)
    {
        
        // IEnumerable
        // get all the string greather than 4 in length
        string[] array = { "Mala", "Prabhakar", "Paul", "Sheo", "Narayan" };

        //var myNames = array.Where(s => s.Length > 4);

        ////var myNames = from s in array
        ////              where s.Length > 4
        ////              select s;

        //foreach (string s in myNames)
        //{
        //    Response.Write(s + "<br />");
        //}


        //Response.Write("<hr />");
        // get all the string that contains "h"
        //return;

        //var names = array.Where(n => n.Contains("h"));

        //foreach (string s in names)
        //{
        //    Response.Write(s + "<br />");
        //}

        //Response.Write("<hr />");
        
        //// get top 3
        //var topSomething = array.Take(3);
        //foreach (string s in topSomething)
        //{
        //    Response.Write(s + "<br />");
        //}

        //Response.Write("<hr />");
        //// skip top 3
        //var skipSomething = array.Skip(3);
        //foreach (string s in skipSomething)
        //{
        //    Response.Write(s + "<br />");
        //}

        //Response.Write("<hr />");
        // sort
        // var sortNames = array.OrderBy(s => s);
        //var sortNames = array.OrderByDescending(s => s);
        //foreach (string s in sortNames)
        //{
        //    Response.Write(s + "<br />");
        //}
        //Response.Write("<hr />");
        // return;
        // get the first one
        //var firstOne = array.Where(s => s.Contains("Sheo")).FirstOrDefault();
        //Response.Write(firstOne + "<br />");

        var names = array.Where(s => s.StartsWith("P")).ToList();
        foreach(string name in names)
        {
            Response.Write(name + "<br />");
        }
        
















    }
}









