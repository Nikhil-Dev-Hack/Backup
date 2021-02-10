using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConstantPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // var name = ConstClass.myName;

        var address = ConstClass.myAddress;
    }

    private class ConstClass
    {
        const string myName = "ITFunda";

        public const string myAddress = "ITFunda";
    }
}