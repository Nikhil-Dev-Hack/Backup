
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using ConsoleApp1.Models;
using ConsoleApp1.Inheritance;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        Console.WriteLine("enter first number: ");
           var a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number");
           var b = int.Parse(Console.ReadLine());
        static void Main(string[] args)
        {
            //Console.WriteLine("Math work");
            //Console.WriteLine("---------Enter two numbers---------");
           
            // int a, b;

            //MathMethods mathMethods = new MathMethods();
            //MathMethods.TakeInputFromUser(a,b);

            MathMethods.AddMethod(a,b);

            MathMethods.SubtractMethod(a,b);

            MathMethods.MultiplicationMethod(a,b);

            MathMethods.DivisionMethod(a,b);

            Console.ReadKey();
        }

       
    }
}
