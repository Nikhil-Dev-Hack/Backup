
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
        static void Main(string[] args)
        {
            //Console.WriteLine("Math work");
            //Console.WriteLine("---------Enter two numbers---------");

            ChildClass childClass = new ChildClass();
            Console.WriteLine(childClass.Ravi());



            ParentClass parentClass = new ParentClass();
            Console.WriteLine(parentClass.Ravi());
            ParentClass po = new ChildClass();
            Console.WriteLine(po.Ravi());



            //int a, b;

            //MathMethods mathMethods = new MathMethods();
            //mathMethods.TakeInputFromUser(out a, out b);

            //MathMethods.AddMethod(a, b);

            //MathMethods.SubtractMethod(a, b);

            //MathMethods.MultiplicationMethod(a, b);

            //MathMethods.DivisionMethod(a, b);

            Console.ReadKey();
        }
    }
}
