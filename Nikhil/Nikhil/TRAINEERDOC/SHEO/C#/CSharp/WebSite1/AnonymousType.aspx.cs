using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnonymousType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        var person = new {FirstName = "Sheo", LastName = "Narayan", Age = "2", Active = true };

        Response.Write(person.FirstName + " " + person.LastName + " " + person.Age + " " + person.Active);

    }
}