using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Sum of two numbers");
            Console.WriteLine("============================");
            Console.WriteLine("Enter first number: ");
            int a =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b =int.Parse(Console.ReadLine());

            var Sum1 = Sum(a, b);

            Console.WriteLine(Sum1);

            Console.ReadKey();
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
