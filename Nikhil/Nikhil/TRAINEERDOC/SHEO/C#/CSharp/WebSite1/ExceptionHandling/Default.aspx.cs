using System;

public partial class ExceptionHandling_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            CallAnotherMethod();

            //int i = Divide();
            // throw new ApplicationException("Error occured.");
        }
        catch (Exception ee)
        {
            Response.Write(ee.ToString());
            //throw;
        }

        // CallAnotherMethod();
    }

    private void CallAnotherMethod()
    {
        int i = 05;
        int j = 0;
        try
        {
            int k = i / j;
        }
        catch (DivideByZeroException ee)
        {
            Response.Write("Divide by zero exception occured. " + ee.ToString());
            throw;
        }
        catch(NullReferenceException ee)
        {
            lblMessage.Text = ee.ToString();
        }
        catch (Exception ee)
        {
            Response.Write(ee.ToString());
            throw;
        }
       
    }

    private int Divide()
    {
        int i = 5;
        int j = 0;
        int result = 0;
        try
        {
            result = i / j;
        }
        catch (Exception ee)
        {
            lblMessage.Text = ee.ToString();
        }
        finally
        {
            Response.Write("FASD");
        }
        return result;
    }
}
