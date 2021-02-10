using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NullableMix : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = null;
        
        int? aa = null;
        if (aa.HasValue)
        {
            Response.Write("aa has some value");
            Response.Write(aa.Value);
        }

        int? x = null;
        int y = 20;
        int? sum = x + y;

        Response.Write(sum.ToString());

    }
}