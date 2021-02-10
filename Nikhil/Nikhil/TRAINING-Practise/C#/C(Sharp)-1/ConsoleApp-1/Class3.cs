using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_1
{
    class Class3
    {
        //Write a C# Sharp program to swap two numbers
        private static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Enter the first number to be swaped");
            a =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the second number to be swaped");
            b =int.Parse( Console.ReadLine());

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a + "is");
            Console.WriteLine(b + "is");

        }
    }
}
