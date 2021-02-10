using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Work_Day_1
{
    public class DivisionOfTwoNumbers
    {
        /// <summary>
        /// It calculates DivisionOfTwoNumbers using pass by value concept
        /// </summary>
        public void Execute()
        {
            int a = 100, b = 20;
            var result = Divi(a, b);
            Console.WriteLine(result);
        }

        private float Divi(int a, int b)
        {
            return a / b;
        }
    }
}
