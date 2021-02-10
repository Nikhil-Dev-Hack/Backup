using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    /// <summary>
    /// Math class interface
    /// </summary>
    interface IMathClass
    {
        /// <summary>
        /// Returns sum of two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Add(int a, int b);

        /// <summary>
        /// Returns difference of two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Substract(int a, int b);

        /// <summary>
        /// Returns multiplication of two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Multiply(int a, int b);

        /// <summary>
        /// Returns division of two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Divide(int a, int b);
    }
}
