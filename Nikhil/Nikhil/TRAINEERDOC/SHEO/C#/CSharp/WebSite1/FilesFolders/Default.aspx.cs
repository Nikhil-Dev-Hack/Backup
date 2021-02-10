using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class FilesFolders_Default : System.Web.UI.Page
{
    string path = "~/FilesFolders/" + DateTime.Now.ToShortDateString().Replace("/", "") + ".txt";

    protected void Page_Load(object sender, EventArgs e)
    {
        path = Server.MapPath(path);
        Response.Write(path);
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        File.WriteAllText(path, txtContent.Text.Trim());
        // write the message now.
        lblMessage.Text = "File created successfully !";
        lblMessage.BackColor = System.Drawing.Color.Yellow;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        File.AppendAllText(path, txtContent.Text.Trim());

        // write the message now.
        lblMessage.Text = "File updated successfully !";
        lblMessage.BackColor = System.Drawing.Color.Yellow;
    }

    protected void btnRead_Click(object sender, EventArgs e)
    {
        string content = File.ReadAllText(path);
        litContent.Text = content.Replace("\n", "<br />");
    }

    protected void btnChangeName_Click(object sender, EventArgs e)
    {
        string thisPath = Server.MapPath("~/FilesFolders/");
        string sourceFile = thisPath + txtName.Text.Trim();
        string targetFile = thisPath + txtNameTo.Text.Trim();

        File.Move(sourceFile, targetFile);
        lblMessage.Text = "File name changed !";
    }

    protected void btnDeletete_Click(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            lblMessage.Text = "File deleted successfully !";
            lblMessage.ForeColor = System.Drawing.Color.Red;
            txtContent.Text = string.Empty;
        }
        else
        {
            lblMessage.Text = "Oooooooops, file doesn't exists !";
        }
    }
}













