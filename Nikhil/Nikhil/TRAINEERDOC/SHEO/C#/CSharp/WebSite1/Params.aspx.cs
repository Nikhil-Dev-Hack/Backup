using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Params : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var sum1 = Add(2, 3);
        Response.Write(sum1.ToString()); // 5

        Response.Write("<br />");
        sum1 = Add(2, 3, 5, 6, 9, 85, 4, 525, 55, 6325, 66546, 552, 5, 5585, 56985, 6356, 66366, 6, 2);

        Response.Write(sum1.ToString()); // 209422 

        Sum(20, 40, 60);
    }

    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}