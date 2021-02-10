using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

public partial class YieldKeyword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        foreach (string s in GetNames())
        {
            Response.Write(s + "<br />");
        }
    }

    static IEnumerable<string> GetNames()
    {
        int i = 0;
        i++;
        yield return i + ". Ram";
        i++;
        yield return i + ". Shyam";
        // yield break;
        i++;
        yield return i + ". Mohan";
    }

    //IEnumerable<string> GetMyNames()
    //{
    //    return "Ram";
    //    return "Shyam";
    //    return "Mohan";
    //}
}