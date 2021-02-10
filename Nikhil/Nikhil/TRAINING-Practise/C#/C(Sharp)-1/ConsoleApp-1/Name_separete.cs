using System;

namespace ConsoleApp_1
{
    /*Write a C# Sharp program to print Hello and your name in a separate line */
    class Name_separete
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your Name");
            var Name = Console.ReadLine();
            Console.WriteLine("Hello:" + Name);
        }
    }
}
