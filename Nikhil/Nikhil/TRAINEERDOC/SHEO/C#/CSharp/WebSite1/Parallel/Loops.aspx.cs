using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading.Tasks;

public partial class Parallel_Loops : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            long s = DateTime.Now.Ticks;
            ForLoop(); 
            long ee = DateTime.Now.Ticks;
            Response.Write("Time: " + (s - ee));            
        }
    }

    void ForLoop()
    {
        //for (int i = 0; i < 50; i++)
        //{
        //    MyFunction(i);
        //}

        Parallel.For(0, 50, i => MyFunction(i));

        Response.Write("<hr />");

        Parallel.ForEach("hello sir ji Namaste", MyCharFunction);
    }

    void MyCharFunction(char c)
    {
        Response.Write(c + "<br />");
    }

    void MyFunction(int i)
    {
        Response.Write((i * i) + "<br />");
    }
}