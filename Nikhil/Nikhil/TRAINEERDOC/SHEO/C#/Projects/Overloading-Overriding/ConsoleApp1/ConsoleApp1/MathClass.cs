using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{
    /// <summary>
    /// Math class that contain the mathematical methods
    /// </summary>
    public class MathClass : IMathClass
    {

        public int Add(int a, int b)
        {
            return a + b - 1;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Substract(int a, int b)
        {
            var data = a - b;
            return data;
        }

        ///// <summary>
        ///// Compares two numbers and returns the result
        ///// </summary>
        ///// <param name="a">Pass the first number</param>
        ///// <param name="b">Pass the second number</param>
        ///// <returns></returns>
        //public string Compare(int a, int b)
        //{
        //    return a == b ? "both are equal" : "both are not equal";
        //}

    }
}
