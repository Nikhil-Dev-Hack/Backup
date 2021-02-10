using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using SampleBO;

public partial class Collections_Collections : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        // ArrayList
        ArrayList arrayL = new ArrayList(); // 10
        arrayL.Add("FirstName");
        arrayL.Add(1);
        arrayL.Add("Address");
        Person persson = new Person();
        persson.FirstName = "FASDF";
        arrayL.Add(persson);
        

        string third = arrayL[2].ToString();

        int age = Convert.ToInt32(arrayL[2]);
        object obj = arrayL[1];
        int objI = int.Parse(obj.ToString());
        for (int i = 0; i < arrayL.Count; i++)
        {
            var ss = arrayL[i];
        }



        // hashtable
        Hashtable hTable = new Hashtable();
        hTable.Add("Name", "Paracetamol");
        hTable.Add("Dose", 5);
        hTable.Add("Manufacturur", "ABC Ltd.");
        hTable.Add("Expiry", DateTime.Now.AddDays(-5));

        string name = hTable["Name"].ToString();
        var is5 = hTable.ContainsValue(5);

        foreach (string key in hTable.Keys)
        { 
            var data12 = hTable[key];
        }


        SortedList sList = new SortedList();
        sList.Add("Fdsa", "Fdsas");


        // BitArray
        BitArray b = new BitArray(2);
        b[0] = true;
        b[1] = false;

        // Queue - FIFO
        Queue q = new Queue();
        q.Enqueue("1");
        q.Enqueue("2");

        var first = q.Peek(); // retrieves the value but do not remove fro the Queue
        
        var data = q.Dequeue(); // 1 retrieves the data but remove
        var data1 = q.Dequeue(); // 2

       
        // Stack - LIFO
        Stack s = new Stack();
        s.Push("First");
        s.Push("Second");
        s.Peek(); // retrieves the value but do not remove from the Stack
        s.Pop(); // retrieves the data but remove

        //====================================================

        List<string> list = new List<string>();
        list.Add("5");
        list.Add("FSDA");
        string str = list[1];


        List<PersonalDetail> listPD = new List<PersonalDetail>();
        PersonalDetail myPd = new PersonalDetail();
        myPd.FirstName = "1 First Name";
        myPd.LastName = "1 Last Name";
        myPd.Age = 50;
        // seting the property
        listPD.Add(myPd);

        listPD.Add(new PersonalDetail()
        {
            FirstName = "2 Fisrt Name",
            LastName = "2 Last Name"
        });


        PersonalDetail pd = listPD[1];
        string secondFirstName = pd.FirstName; // 2 First Name

        foreach (PersonalDetail pd1 in listPD)
        {

        }
        
        //// ==================
        Stack<int> st = new Stack<int>(); // generic version
        st.Push(9);
        Stack<Person> sP = new Stack<Person>();

        Dictionary<int, string> dList = new Dictionary<int, string>();
        dList.Add(1, "fdsaf");

        // SortedList
        Dictionary<string, string> sl = new Dictionary<string, string>();
        sl.Add("s", "Sheo");
        sl.Add("b", "Prabhakr");
        sl.Add("a", "Abhishek");

        foreach(KeyValuePair<string, string> c in sl)
        {
            Response.Write(c.Key + "<br />");
        }
        var dictData = sl["b"]; // Prabhakar

        Dictionary<int, string> dl1 = new Dictionary<int, string>();

        MyGClass<string> mgc = new MyGClass<string>("fadsfads");
        Response.Write("<br />" + mgc.GetData());

        MyGClass<int> mgInt = new MyGClass<int>(50);
        string sInt = mgInt.GetData();

        PersonalDetail pdG = new PersonalDetail();
        pdG.FirstName = "Whatever";
        MyGClass<PersonalDetail> pDetails = new MyGClass<PersonalDetail>(pdG);

















        
    }
}
