using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Animal
{
    /// <summary>
    /// Summary description for Cat
    /// </summary>
    public class Cat
    {
        int _age = 20;

        public Cat()
        {
            Age = _age;
            //
            // TODO: Add constructor logic here
            //
        }

        public Cat(int age)
        {
            Age = age;
            //
            // TODO: Add constructor logic here
            //
        }

        public int Age = 0;

        public string Color { get; set; }

        public int Legs { get; set; }

        public int GetAge()
        {
            // write your code
            return Age;
        }

    }
}