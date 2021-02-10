using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DynamicVar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dynamic age = new MyClass();
        Response.Write(age.GetType());

        int myAge = 5;

        Response.Write("<br />" + myAge.GetType());

        dynamic myObj = null;
        
        switch (myAge)
        {
            case 1:
                myObj = new MyClass();
                break;
            case 2 :
                myObj = new Class1();
                break;            
        }
    }

    public class MyClass
    {
        public int GetAge()
        {
            return 230;
        }
    }
}