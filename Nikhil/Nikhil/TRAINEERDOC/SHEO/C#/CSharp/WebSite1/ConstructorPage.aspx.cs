using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConstructorPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Class7 c7 = new Class7();

        Class7 c77 = new Class7(5);

        int a  = c77.GetAge();
    }
}