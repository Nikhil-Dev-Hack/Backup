using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public void Page_Load(object sender, EventArgs e)
    {
        Response.Write("My data <br />");

        goto MyLabel;

        Array a = Array.CreateInstance(typeof(string), 4);

        a.SetValue("IT", 0);
        a.SetValue("Funda", 1);
        a.SetValue("Corporation", 2);
        a.SetValue("Ltd.", 3);
        
        foreach (string s in a)
        {
            Response.Write(s + "<br />");
        }

    MyLabel:
        {
            Response.Write("This is written using Label");
            Response.Write(". Yes");
        }
    }
}
