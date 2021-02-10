using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Work_Day_1
{
    /// <summary>
    /// It Performs PrintAllStringsInArrayUsingCall using call method
    /// </summary>
    public class PrintAllStringsInArrayUsingCall
    {
        public static void Execute()
        {
            string result = string.Join(", ", GetNameArray());

            
            Console.WriteLine("{0}", result);
        }

        static string[] GetNameArray()
        {
            // Put 3 tree names in the array and return it.
            string[] array = { "One", "Two", "Three", "Four","Fifth" };
            return array;
        }
    }
}
