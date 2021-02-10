using System;
using System.Threading;

namespace C_Sharp_Rev_
{
    public class thread
    {
        public void call()
        {
            Thread thread = new Thread(DoSomething);
            thread.Start();
            
            Console.Write(thread.IsAlive);
            thread.Join();
            
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" Load ");
            }


            Console.Write(thread.IsAlive);
            thread.Abort();
        }

        public void DoSomething()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" Something ");
            }
        }
    }



}
