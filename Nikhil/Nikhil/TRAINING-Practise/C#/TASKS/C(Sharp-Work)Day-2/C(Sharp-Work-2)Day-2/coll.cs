using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Work_2_Day_2
{
    class coll
    {
        public void naren()
        {
            //Hashtable h = new Hashtable();
            //h.Add(1, "narendra");
            //h.Add("naren", "gv");
            //foreach(DictionaryEntry d in h)
            //{
            //    Console.WriteLine(d.Key+"     "+d.Value);
            //}
            List<string> dep= new List<string>();

            dep.Add("nikhil");
            dep.Add("narendra");
            foreach(string g in dep)
            {
                Console.WriteLine(g);
            }
        }
    }
}
