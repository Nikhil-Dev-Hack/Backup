using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InputTypesubmit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Write("Name: " + Request.Form["myName"] + "<br />");
        Response.Write("Email: " + Request.Form["myEmail"] + "<br />");
        Response.Write("Url: " + Request.Form["myUrl"] + "<br />");
        Response.Write("Color: " + Request.Form["myColor"] + "<br />");
        Response.Write("Number: " + Request.Form["myNumber1"] + "<br />");
        Response.Write("Month: " + Request.Form["myMonth"] + "<br />");
        Response.Write("Date: " + Request.Form["myDateTime"] + "<br />");
        Response.Write("DateTime local: " + Request.Form["myDateTimeLocal"] + "<br />");
        Response.Write("Week: " + Request.Form["myWeek"] + "<br />");
        Response.Write("Range: " + Request.Form["myRange"] + "<br />");
        Response.Write("Files: " + Request.Form["myFiles"] + "<br />");
        Response.Write("List item: " + Request.Form["myList"] + "<br />");        

    }
}