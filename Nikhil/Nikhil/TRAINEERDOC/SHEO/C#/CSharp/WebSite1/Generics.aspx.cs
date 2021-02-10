using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;


public partial class Generics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        GenericClass<string> gc = new GenericClass<string>();



        // example 1

        ArrayList aList = new ArrayList();
        aList.Add("Prabhakar"); // string
        aList.Add(30); // int
        aList.Add(DateTime.Now); // DateTime
        aList.Add(30.50); // decimal

        string name = (string) aList[0];
        int age = (int)aList[1];


        // example 2
        ArrayList aAge = new ArrayList();
        aAge.Add(30.50);
        aAge.Add(50.54);
        aAge.Add(70.5);
        aAge.Add(80.62);
        aAge.Add("FASFASD");


        List<double> listD = new List<double>();
        listD.Add(60.63);

        foreach (double d in listD)
        {

        }


        SortedList sList = new SortedList();
        sList.Add("fsd", "fdsa");

        string s = sList["fsd"].ToString();

        SortedList<int, string> sListD = new SortedList<int, string>();
        sListD.Add(1, "Adfadsfdsa");

        string ss = sListD[1];

       


        foreach (object a in aAge)
        {
            Response.Write(a.ToString());
        }

        

        List<int> list = new List<int>();
        list.Add(30);
        list.Add(50);

        foreach (int mydata in list)
        {

        }

              

    }
}
