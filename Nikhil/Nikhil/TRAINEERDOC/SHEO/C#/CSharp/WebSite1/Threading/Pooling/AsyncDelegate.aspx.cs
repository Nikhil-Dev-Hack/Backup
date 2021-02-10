using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
public partial class Threading_Pooling_AsyncDelegate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Func<string, int> method = MyMethod;
        
        IAsyncResult myResult = method.BeginInvoke("Sheo Narayan", null, null);

        // perofrm another work in between 
       

       int output = method.EndInvoke(myResult);

        Response.Write(output);
    }

    int MyMethod(string str)
    {
        return str.Length;
    }
}