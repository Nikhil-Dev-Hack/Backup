using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class keygen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
  
        if (Request.Form["securityKey"] != null)
        {
            Response.Write(Request.Form["securityKey"]);
        }
    }
}