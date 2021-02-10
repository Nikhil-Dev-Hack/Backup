using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Streams_StringReder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int count = 0;
        using (StringWriter writer = new StringWriter())
        {
            for (int i = 0; i < 10; i++)
            {
                count++;
                writer.Write(count + " line <br />");
            }
            litReader.Text = writer.ToString();
        }
        litReader.Text += "<hr /><h4>Reading now</h4><hr />";
        ReadText();

    }

    private void ReadText()
    {
        string myString = "1st line \n 2nd line \n 3rd line \n 4th line";
        // read all at one time
        using (StringReader reader = new StringReader(myString))
        {
            litReader.Text += reader.ReadToEnd();
        }

        litReader.Text += "<hr />";

        // read line by line
        using (StringReader reader = new StringReader(myString))
        {
            while (true)
            {
                string thisLine = reader.ReadLine();
                if (thisLine == null)
                {
                    break;
                }
                litReader.Text += thisLine + "<br />";
            }
        }
    }
}