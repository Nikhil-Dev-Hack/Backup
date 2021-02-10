using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MathMethods
    {
        public void TakeInputFromUser(out int a, out int b)
        {
            Console.WriteLine("enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = int.Parse(Console.ReadLine());
        }

        public static void DivisionMethod(int a, int b)
        {
            var divide = a / b;
            Console.WriteLine("The division of {0} and {1} is: {2}", a, b, divide);
        }

        public static void MultiplicationMethod(int a, int b)
        {
            var multiply = a * b;
            Console.WriteLine("The multiplication of {0} and {1} is: {2}", a, b, multiply);
        }

        public static void SubtractMethod(int a, int b)
        {
            var subtract = a - b;
            Console.WriteLine("The difference of {0} and {1} is: {2}", a, b, subtract);
        }
        public static void AddMethod(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, sum);
        }
    }
}
