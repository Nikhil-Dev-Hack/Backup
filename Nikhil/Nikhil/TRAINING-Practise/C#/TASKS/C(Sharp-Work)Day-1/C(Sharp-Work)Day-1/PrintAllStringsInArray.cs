using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Work_Day_1
{
    /// <summary>
    /// It Performs PrintAllStringsInArray using String 
    /// </summary>
    public class PrintAllStringsInArray
    {
        public static void Execute()
        {
            string[] array = { "Karthik", "Narendra", "Swapna", "Ravi teja", "Shiva" };
            PrintArray(array);
        }

        private static void PrintArray(string[] arraystri)
        {
            foreach (var item in arraystri)
            {
                Console.WriteLine(item);
            }
        }
    }
 
}
