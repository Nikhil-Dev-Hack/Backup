using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // string s = string.Empty;

        /*
        int i = 0;
        DateTime d = new DateTime();
        */

        int sum = Add(50, 30);



    }

    /// <summary>
    /// This method adds two numbers ()
    /// </summary>
    /// <param name="a">This is the first paramter</param>
    /// <param name="b"></param>
    /// <returns>It returns an integer</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

}