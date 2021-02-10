using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Work_Day_1
{
    public class SwapOfTwoNumbers
    {
        /// <summary>
        /// It Performs SwapOfTwoNumbers using ref  concept
        /// </summary>
        public void Execute()
        {
          
            int a, b;
            Console.WriteLine("Enter the First number(a)" );
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number(b)");
            b = int.Parse(Console.ReadLine());
            Swap(ref a, ref b);
            Console.WriteLine($"After swaping function is executed, a= {a}, b={b}");

        }

        private void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
