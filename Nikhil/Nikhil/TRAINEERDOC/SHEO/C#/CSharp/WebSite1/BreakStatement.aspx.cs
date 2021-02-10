using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BreakStatement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // return;

        // not good
        String s = "My data";
        s = "fdasfasd";
        if (s.Equals("FDAS"))
        {
            // do this
        }
            
        // very good
        string ss = "My data"; // ** always use this
        ss = "fdasfasd";
        if (s.Equals("FDAS"))
        {
            // do this
        }


        Int32 iii = 500;
        int ii = 500;

        // very good
        long ll = 5000;
        




        for (int i = 0; i < 20; i++)
        {
            Response.Write(i.ToString() + "<br />");

            for(int j = 0; j < 3; j++)
            {
                Response.Write(j.ToString() + "<hr />");

                if (j.Equals(2))
                {
                    break; // breaks the child loop
                    // continue;
                    // return // halt the execution or stops the execution
                }
        
            } // child loop
        
        } // parent loop
    }
}