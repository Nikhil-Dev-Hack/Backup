using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CallAMethod();
    }

    private void CallAMethod()
    {
        throw new NotImplementedException();

        var i = 10;
        var j = 0;
        try
        {
            var result = i / j;
            lblResult.Text = result.ToString();
        }
        catch (Exception ee)
        {
            lblMessage.Text = "Error occured. " + ee.Message;
        }       

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
        try
        {
            var i = int.Parse(txtA.Text.Trim());
            var j = int.Parse(txtB.Text.Trim());

            var result = i / j;
            lblResult.Text = "Result is : " + result.ToString();
        }
        catch (DivideByZeroException ee)
        {
            // lblMessage.Text = "Error occured. " + ee.ToString();
            lblMessage.Text = "Sorry, you should have studied in 8th class then try this program. " + ee.Message;
            
            // send email code here.
        }
        catch (FormatException ee)
        {
            // lblMessage.Text = "Error occured. " + ee.ToString();
            lblMessage.Text = "Sorry, you should know the format. " + ee.Message;

            // send email code here.
        }
        catch (Exception ee)
        {
            // lblMessage.Text = "Error occured. " + ee.ToString();
            lblMessage.Text = "Sorry, Error occured. " + ee.Message;

            // send email code here.
        }
    }
}