using System;

namespace C_Sharp__2
{
    public class Program
    {
        /*C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.*/
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the First number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            b = int.Parse(Console.ReadLine());

            if (a > b || a < b)
            {
                Console.WriteLine(a + b);
            }
            else if(a == b)
            {
                Console.WriteLine((a + b) * 3);
            }
        }
    }
}
