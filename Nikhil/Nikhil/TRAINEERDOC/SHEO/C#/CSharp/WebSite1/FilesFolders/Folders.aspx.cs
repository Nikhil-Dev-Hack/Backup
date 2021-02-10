    
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FilesFolders_Folders : System.Web.UI.Page
{
    string path = "~/FilesFolders/";

    protected void Page_Load(object sender, EventArgs e)
    {
        path = Server.MapPath(path);
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        Directory.CreateDirectory(path + txtName.Text.Trim());

        lblMessage.Text = "Directory created successfully !";
        lblMessage.ForeColor = System.Drawing.Color.Green;
    }


    protected void Rename_Click(object sender, EventArgs e)
    {
        Directory.Move(path + "Naidu", path + "Gopal");
        lblMessage.Text = "Directory renamed successfully !";
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Directory.Delete(path + "Gopal");
        lblMessage.Text = "Directory deleted successfully !";
    }

    protected void btnList_Click(object sender, EventArgs e)
    {
        //path = @"E:\ITFundaCorp\TUTORIALS\C#\A-WhileTraining\WebSite1";
        StringBuilder strB = new StringBuilder("<ol>", 500);
        foreach (string dir in Directory.GetDirectories(path))
        {
            strB.Append("<li>" + dir + "</li>");
        }
        strB.Append("</ol>");
        litMessage.Text = strB.ToString();
    }

    protected void btnListFiles_Click(object sender, EventArgs e)
    {
        //path = @"E:\ITFundaCorp\TUTORIALS\C#\A-WhileTraining\WebSite1";
        StringBuilder strB = new StringBuilder("<ol>", 500);
        foreach (string file in Directory.GetFiles(path))
        {
            strB.Append("<li>" + file + "</li>");
        }
        strB.Append("</ol>");
        litMessage.Text = strB.ToString();
    }
}