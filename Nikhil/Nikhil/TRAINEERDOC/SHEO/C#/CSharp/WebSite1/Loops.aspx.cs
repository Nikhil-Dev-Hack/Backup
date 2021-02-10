using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Loops : System.Web.UI.Page
{
    /// <summary>
    /// This method executes when the page is loaded
    /// </summary>
    /// <param name="sender">The control that is raising this event</param>
    /// <param name="e">The event arguments</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] names = { "Sandhya", "Tapaswi", "Nagi Reddy", "Harish", "Kiran" };

        int[] ages = new int[3];

        ages[0] = 112;
        ages[1] = 1112;
        ages[2] = 152;

        Array a = Array.CreateInstance(typeof(string), 4);
        a.SetValue("IT", 0);
        a.SetValue("Funda", 1);
        a.SetValue("Corporation", 2);
        a.SetValue("Ltd.", 3);

        foreach (string name in names)
        {
            Response.Write(name + "<br />");
        }
        Response.Write("<hr />");
        // return;


        for (int i = 0; i < names.Length; i++)
        {
            Response.Write(names[i] + "<br />");

            //for (int ii = 0; ii < 3; ii++)
            //{
            //    if (ii == 2)
            //    {
            //        break;
            //    }
                
            //}            
        }
        Response.Write("<hr />");

        //foreach (var i in ages)
        //{
        //    Response.Write(i + "<br />");
        //}

        
    }

    /// <summary>
    /// This method adds two integer
    /// </summary>
    /// <param name="a">The first integer to add</param>
    /// <param name="b">The second integer to add</param>
    /// <returns>Returns the sum of the two integers</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void SubmitData(object sender, EventArgs e)
    {
        var age = int.Parse(txtAage.Text.Trim());

        bool isGreaterThan10 = false;
        int counter = 0;

        // it doesn't run even a single time
        while (!isGreaterThan10)
        {
            Response.Write(counter.ToString() + "<br />");
            counter++;
            

            isGreaterThan10 = counter > 2010;
        }

        // it runs at least once
        do
        {
            Response.Write(counter.ToString() + "<br />");
            counter++;
        } while (!isGreaterThan10);

    }
}