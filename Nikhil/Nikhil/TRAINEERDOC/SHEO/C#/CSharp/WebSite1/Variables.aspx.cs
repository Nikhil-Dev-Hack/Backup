using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Variables : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // declaring default variables

        decimal f = default(decimal);

        Response.Write(f.ToString());

        bool b = default(bool);

        Response.Write(b.ToString());

        DateTime d = default(DateTime);

        Response.Write(d.ToString());


        // return;

        string myName = "Sriniwas";

        // String mySName = "Laxmi";

        var myFirstName = "Gopal";

        char sex = 'M';

        var myAge = 30;
        
       //  Int32 myAgeI = 50;


        var points = 30f;

        float myPoints = 30f;

        double doubleData = 20.50;

        decimal decimalData = 20.5M;

        Response.Write("<p>Decimal data: " + decimalData.ToString() + "</p>");

        var firstName = "Krishna \"+\" Srinivas";

        //var abstract = "my name";



        Response.Write(firstName);





        // var abstract = "Kuar";

        // Response.Write(myName);

        //MyClass mc = new MyClass();
        //mc.myName = "Pratik Nothing";


        //Response.Write(mc.myName);
    }


    public class MyClass
    {
        // fadsfasd

        public string myName = "Pratik something";

    }
}