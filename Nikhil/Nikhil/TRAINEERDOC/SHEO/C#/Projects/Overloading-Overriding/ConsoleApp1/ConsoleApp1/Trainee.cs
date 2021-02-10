using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Trainee
    {
        public Trainee()
        {
            FullName = "Sai Krishna";
            Age = 22;
        }

        public string FullName { get; set; }

        public int Age { get; set; }


        public string GetDetatils()
        {
            string data = FullName + " " + Age;
            return data;
        }
    }
}
