using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class FilesFolders_Search : System.Web.UI.Page
{
    string path = "~/FilesFolders/";

    protected void Page_Load(object sender, EventArgs e)
    {
        path = Server.MapPath(path);
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {

        var files = Directory.GetFiles(path, txtName.Text.Trim(), SearchOption.AllDirectories);
        StringBuilder strB = new StringBuilder("<ul>", 500);
        foreach(var file in files)
        {
            strB.Append("<li>" + file + "</li>");
        }
        strB.Append("</ul>");

        litList.Text = strB.ToString();              
    }
}