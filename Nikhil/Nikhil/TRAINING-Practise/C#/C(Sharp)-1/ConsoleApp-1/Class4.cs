using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_1
{
    class Class4
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            string b = Console.ReadLine();

            var sum = Sum(int.Parse(a), int.Parse(b));
            var sub = Sub(int.Parse(a), int.Parse(b));
            var multi = Multi(int.Parse(a), int.Parse(b));
            var div = Div(int.Parse(a), int.Parse(b));
            var mod = Mod(int.Parse(a), int.Parse(b));

            Console.WriteLine("The sum of " + a + "and" + b + "is:" + sum);
            Console.WriteLine("The sub of " + a + "and" + b + "is:" + sub);
            Console.WriteLine("The multi of " + a + "and" + b + "is:" + multi);
            Console.WriteLine("The div of " + a + "and" + b + "is:" + div);
            Console.WriteLine("The mod of " + a + "and" + b + "is:" + mod);
            Console.ReadKey();
        }
        private static int Sum(int a, int b)
        {
            return a + b;
        }
        private static int Sub(int a, int b)
        {
            return a - b;
        }
        private static int Multi(int a, int b)
        {
            return a * b;
        }
        private static int Div(int a, int b)
        {
            return a / b;
        }
        private static int Mod(int a, int b)
        {
            return a % b;
        }
    }


}
