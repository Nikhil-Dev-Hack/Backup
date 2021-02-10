using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SomethingTrick : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Add();

        DataTable table = new DataTable();
        table = GetData();


    }

    private DataTable GetData()
    {
        // write code here
        return new DataTable();
    }

    private void Add()
    {
        int a = 0;
        int b = 5;
        int sub = a + b;
    }
}