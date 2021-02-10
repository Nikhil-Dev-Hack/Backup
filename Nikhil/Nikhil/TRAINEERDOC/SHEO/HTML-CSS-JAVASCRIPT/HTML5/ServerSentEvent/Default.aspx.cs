using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServerSentEvent_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // SendSimpleData();

        // SentJSONData();

        SendEventSpecificData();

    }

    private void SendSimpleData()
    {
        // sending normal data
        Response.ContentType = "text/event-stream";

        for (int i = 0; i < 5; i++)
        {
            // two \n\n denotes the end of the stream
            Response.Write("data: " + i + "." + DateTime.Now.ToString() + " \n\n");
            Response.Flush();

            System.Threading.Thread.Sleep(2000);
        }

        Response.Close();
    }


    private void SendEventSpecificData()
    {
        // sending normal data
        Response.ContentType = "text/event-stream";

        for (int i = 0; i < 5; i++)
        {
            // two \n\n denotes the end of the stream
            // Response.Write("data: " + i + "." + DateTime.Now.ToString() + "\n\n");

            Response.Write("retry: 20000\n"); // retry after 20000 millisecond
            Response.Write("event: Insert\n");
            Response.Write("data: INSERT " + i + "." + DateTime.Now.ToString() + "\n\n");
            Response.Flush();

            System.Threading.Thread.Sleep(1000);            
        }

        Response.Close();
    }
       
    private void SentJSONData()
    {
        // sending json data
        Response.ContentType = "text/event-stream";

        for (int i = 0; i < 5; i++)
        {
            string json = "[{ \"name\": \"Sheo\", \"Country\":\"India\"},  { \"name\": \"Vijay\", \"Country\":\"Bangladesh\"}] ";
            // two \n\n denotes the end of the stream
            Response.Write("data: " + json + "\n\n");
            Response.Flush();

            System.Threading.Thread.Sleep(1000);
        }

        Response.Close();
    }
}