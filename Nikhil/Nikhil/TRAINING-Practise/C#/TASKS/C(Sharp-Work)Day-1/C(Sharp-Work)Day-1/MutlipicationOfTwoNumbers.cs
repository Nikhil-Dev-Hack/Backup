using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Work_Day_1
{
    public class MutlipicationOfTwoNumbers
    {
        /// <summary>
        /// It calculates MultipicationofTwoNumbers using pass by value concept
        /// </summary>
        public void Execute()
        {
            int a = 10, b = 20;
            var result = Multi(a, b);
            Console.WriteLine(result);
        }

        private float Multi(int a, int b)
        {
            return a * b;
        }
    }
}
