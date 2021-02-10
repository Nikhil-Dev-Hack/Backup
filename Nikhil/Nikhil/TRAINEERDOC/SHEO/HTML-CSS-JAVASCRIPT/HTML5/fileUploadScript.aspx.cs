using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class fileUploadScript : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Request.Form.ToString());

        for (char c = 'a'; c < 'z'; c++)
        {
            Response.Write(c + "<br />");
        }
    }
}