using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ExceptionHandling_CheckedUnChecked : System.Web.UI.Page
{
    // Checked -  the size and throw overflow exception if violated
    // Unchecked -  to disable the overfloww exception, use unchecked

    protected void Page_Load(object sender, EventArgs e)
    {
        int a = int.MaxValue;
        Response.Write(a.ToString() + "<br />");

        // int bb = a + 647; // no error
        int bb = checked(a + 3); // error 

        
        Response.Write(bb.ToString());
    }
}