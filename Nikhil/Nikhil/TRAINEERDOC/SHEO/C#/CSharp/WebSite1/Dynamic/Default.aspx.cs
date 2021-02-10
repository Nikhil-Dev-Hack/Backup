using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Dynamic;

public partial class Dynamic_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        // Response.Write(Add("FDASFASD", " ABC"));

        // following doesn't show error
        dynamic mc = new MyClass();
        mc.CallMe("call me");
        mc.ReadMe("read me");
        Response.Write("<br />" + mc.Add(55, 66));
    }

    private dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }

    public class MyClass : DynamicObject 
    {
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            // get the method being called using "binder.Name".
            HttpContext.Current.Response.Write(binder.Name + " method was called with parameter : " + args[0] + " <br />");            
            result = null;
            return true;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}