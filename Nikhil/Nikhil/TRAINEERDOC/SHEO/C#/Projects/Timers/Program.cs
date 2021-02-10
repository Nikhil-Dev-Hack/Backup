
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using ConsoleApp1.Models;
using ConsoleApp1.Inheritance;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Timers;

namespace ConsoleApp2
{
    class Program
    {
        static int count = 0;
        static Timer timer;

        static void Main(string[] args)
        {

            timer = new Timer(4000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            Console.ReadKey();
        }




    }
}
