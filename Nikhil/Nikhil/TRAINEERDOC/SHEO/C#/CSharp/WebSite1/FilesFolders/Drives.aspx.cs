using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Management;

public partial class FilesFolders_Drives : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListDrives();
        Response.Write("<hr />");
        ListLogicalDrives();
    }

    private void ListDrives()
    {
        var drives = DriveInfo.GetDrives();

        foreach(var drive in drives)
        {
            if (drive.IsReady)
            {
                Response.Write(drive.Name + " " + drive.RootDirectory + " " + drive.TotalSize + " " + drive.AvailableFreeSpace + "<br />");
            }
        }
    }

    private void ListLogicalDrives()
    {
        var drives = System.IO.Directory.GetLogicalDrives();

        foreach (var drive in drives)
        {
            Response.Write(drive + "<br />");
        }
    }
}