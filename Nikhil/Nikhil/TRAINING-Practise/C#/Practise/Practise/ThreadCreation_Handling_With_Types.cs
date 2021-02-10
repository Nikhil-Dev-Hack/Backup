using System;
using System.Threading;
using System.Threading.Tasks;

namespace Practise
{
    public class ThreadCreation_Handling_With_Types
    {
        public void ThreadNormal()
        {
            Thread thread = new Thread(Method);
            thread.Start();
        }

        public void ThreadAnoy()
        {
            
            Thread task2 = new Thread(delegate()
            {
                Method();
            });
            task2.Start();
        }


        public void ThreadLambda()
        {
            Thread thread3 = new Thread(() => Method());
            thread3.Start();
        }

        private void Method()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("You are being executed by thread");
            }
        }
    }
}

