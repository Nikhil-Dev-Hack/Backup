using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PRACTISE.THREADING
{
    public class THREADINGSYSNTAX
    {
        public void ThreadNormal()
        {
            Thread thread = new Thread(Method1);
            thread.Start();
            
        }

        public void ThreadAnoy()
        {
            Thread thread = new Thread(delegate ()
            {
                Method1();
            });thread.Start();
        }

        public void ThreadLambda()
        {
            Thread thread = new Thread(() =>
            {
                Method1();
            });thread.Start();
        }

        private void Method1()
        {
            var Call = new List<int>();
            Console.WriteLine("Enter a value");
            var g = int.Parse(Console.ReadLine());
            for (int i = 0; i < g; i++)
            {
                Console.WriteLine($"Hello " + i);
                Call.Add(i);
            }
        }
    }
}
