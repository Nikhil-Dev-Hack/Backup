using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PlaceHolderFromBack : System.Web.UI.Page
{
    protected string _placeHolder = string.Empty;
    protected string _list = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        // you got from the database

        _placeHolder = "Something from database";

        _list = "<option value=\"va1\" /><option value=\"va2\" /><option value=\"va2\" />";
    }
}