using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyClass1
{

    /// <summary>
    /// Summary description for MyClass
    /// </summary>
    public class MyClass 
    {

        public int Age = 0;

        public MyClass()
        {
            //
        }

        public MyClass(string firstName)
        {
            FirstName = firstName;
        }

        public MyClass(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetName()
        {
            return FirstName + " " + LastName;
        }
    }

}