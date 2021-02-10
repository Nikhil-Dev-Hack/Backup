using System;

namespace ConsoleApp_1
{
    class Class1
    {
        /*Write a C# Sharp program to print the sum of two numbers.*/
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            string b = Console.ReadLine();

            var sum = Sum(int.Parse(a), int.Parse(b));


            Console.WriteLine("The sum of " + a + "and" + b + "is:" + sum);
            Console.ReadKey();
        }
        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }

}
