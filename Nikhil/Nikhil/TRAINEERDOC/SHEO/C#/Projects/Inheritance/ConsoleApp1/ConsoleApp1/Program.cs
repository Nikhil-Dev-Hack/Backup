
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using ConsoleApp1.Models;
using ConsoleApp1.Inheritance;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            ParentClass parent = new ParentClass();
            parent.PublicGetMyName();


            ChildClass child = new ChildClass();
            
            
            Console.ReadKey();
        }

        


    }
}
