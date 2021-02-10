using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string myAddress = "abstract";


        string myName;
        myName = "Ram";

        string address = string.Empty;

        int age = 0;

        bool isActive = false;

        DateTime thisDate = DateTime.Today;

        address = "My address";
        age = 50;
        isActive = true;
        thisDate = DateTime.Today.AddDays(5);

        Response.Write("Today's date is : " + thisDate.ToShortDateString());
        Response.Write("<hr />");

        Response.Write("Today's date is : " + thisDate.ToLongDateString());
        Response.Write("<hr />");

        DateTime tDate = new DateTime();

        Response.Write("Today's date is : " + tDate);

        // =====================

        var myAge = 50;

        var mySubject = "ASP.NET 4";

        Response.Write("<hr />");

        Response.Write(mySubject.GetType());

        Response.Write("<hr />");

        string thisString = "Today's training is in \"C#\".";

        Response.Write(thisString);


        object obj = age; // (boxing)

        int j = (int)obj; // unboxing

        Response.Write("<hr />");

        var myData = mySubject.Equals("ASP.NET 4") ? "Yes" : "No";

        //if (mySubject.Equals("ASP.NET 4"))
        //{
        //    myData = "Yes";
        //}
        //else
        //{
        //    myData = "No";
        //}


        Response.Write(myData);

    }


    public class MyClass
    {
        ///fdsafdsafadsfsdf asdfds

    }

}