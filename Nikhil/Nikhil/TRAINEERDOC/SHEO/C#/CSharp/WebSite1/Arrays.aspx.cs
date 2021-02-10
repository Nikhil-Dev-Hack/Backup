using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Arrays : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Array a = Array.CreateInstance(typeof(string), 4);

        a.SetValue("IT", 0);
        a.SetValue("Funda", 1);
        a.SetValue("Corporation", 2);
        a.SetValue("Ltd.", 3);

        foreach (string s in a)
        {
            Response.Write(s + "<br />");
        }

        Response.Write("<hr />");

        string[] aa = new string[4];
        aa[0] = "IT";
        aa[1] = "Funda";
        aa[2] = "Corporation";
        aa[3] = "Ltd.";

        foreach (string s in aa)
        {
            Response.Write(s + "<br />");
        }
    }
}