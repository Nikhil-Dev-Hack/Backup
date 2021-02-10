using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strings_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var company = "TollPlus Inc";
        //company = company.Replace("Inc", "Pvt. Ltd.");

        // find replace case insensitive
        // remove options to make it case sensitive
        //Regex r = new Regex("inc", RegexOptions.IgnoreCase);
        //company = r.Replace(company, "Pvt Ltd.");

        //Response.Write(company);

        //Regex r = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        //string myEmail = "ram@ramfdas.com";
        //bool isCorrectFormat = r.IsMatch(myEmail);

        //Response.Write(isCorrectFormat.ToString());

        //var result = string.Empty;
        //result = company.ToLower();
        //result = company.ToUpper();

        //Response.Write(result);



        // finding words
        //var mySentence = "This is a good boy and this is a good girl.";

        //Response.Write(mySentence.IndexOf("this", StringComparison.Ordinal));
        //Response.Write("<br />");
        //Response.Write(mySentence.LastIndexOf("this", StringComparison.CurrentCultureIgnoreCase));


        // This is I do not know but I should know.
        //var one = "I do not know";
        //var two = "I should know";
        //var result = "This is " + one + " but " + two;
        //result = "This is {0} but {1}.";

        //result = string.Format(result, one, two);

        //Response.Write(result);


        // comparison
        var fever = "Paracetamol";
        var pain = "paracetamol";

        //if (fever.Equals(pain, StringComparison.CurrentCultureIgnoreCase))
        //{
        //    Response.Write("how can fever is equal to pain");
        //}
        //else
        //{
        //    Response.Write("how can fever is NOT equal to pain");
        //}

        //Response.Write("<hr />");

        //var result = fever.Substring(1, 7);

        //Response.Write(result);

        //======================
        //String appending
        // WRONG WAY
        //string data = string.Empty;
        //for (int i = 0; i < 500; i++)
        //{
        //    data += i + "<br />";
        //}
        //Response.Write(data);

        // RIGHT WAY
        //StringBuilder strB = new StringBuilder(500);
        //for (int i = 0; i < 500; i++)
        //{
        //    strB.Append(i + "<br />");
        //}

        //Response.Write(strB.ToString());

        //=============================

        // string csvs = "1,2,3,4,5,6";

        //StringBuilder strB = new StringBuilder();

        //for (int i = 0; i < 10; i++)
        //{
        //    strB.Append(i + ",");
        //}
        //string csvs = strB.ToString();

        //string[] ar = csvs.Split(',');

        //Response.Write(ar[4]);





    }
}