using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonalDetails;


public partial class Enumerations : System.Web.UI.Page
{
    /// <summary>
    /// Page load event of the page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {       

       WriteDay(Day.Wednesday);

         Day myDay = (Day)Enum.Parse(typeof(Day), "Monday", true);

        Response.Write("<hr />");

        Response.Write((int)Day.Wednesday);

        Response.Write((int)myDay);
    }


    /// <summary>
    /// This method writes the day
    /// </summary>
    /// <param name="d">Pass the Day as enumerations</param>
    private void WriteDay(Day d)
    {
        switch (d)
        {
            case Day.Friday:
                Response.Write("It is Friday");
                //fsadfadsfadfdsaf
                //fdasfadsfads
                break;
            case Day.Monday:
                Response.Write("This is Monday");
                break;
            case Day.Saturday:
                Response.Write("This is Saturday");
                break;
            case Day.Sunday:
                Response.Write("This is Sunday");
                break;
            case Day.Thursday:
                Response.Write("This is Thursday");
                break;
            case Day.Tuesday:
                Response.Write("This is Tuesday");
                break;
            case Day.Wednesday:
                Response.Write("This is Wednesday");
                break;
        }

        // 3rd day of the week
        
    }

    /// <summary>
    /// Day enumerations denoting the days of week
    /// </summary>
    enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

}