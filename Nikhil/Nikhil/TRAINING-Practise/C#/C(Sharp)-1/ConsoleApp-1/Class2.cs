using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_1
{
    /*Write a C# Sharp program to print the result of dividing two numbers*/
    class Class2
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            var a = Console.ReadLine();
            Console.WriteLine("Enter the number to divide");
            var b = Console.ReadLine();

            var div = Div(int.Parse(a), int.Parse(b));

            Console.WriteLine("The Div of " + a + "and" + b + "is:" + div);
            Console.ReadKey();

        }
        private static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
