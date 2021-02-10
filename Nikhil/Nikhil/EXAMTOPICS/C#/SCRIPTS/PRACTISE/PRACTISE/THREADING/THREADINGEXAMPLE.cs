using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PRACTISE.THREADING
{
    public class THREADINGEXAMPLE
    {
        public void TicketCancelation()
        {
            var cts = new CancellationTokenSource();

            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;
            po.MaxDegreeOfParallelism = 2;

            Console.WriteLine("Press 'q' to Terminate the process");

            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar == 'q')
                    cts.Cancel();
                Console.WriteLine("\n Press any key to exit");
            });

            IList<string> invoices = new List<string>();

            Console.WriteLine("Enter the Loop Value");

            var User = int.Parse(Console.ReadLine());

            for (int i = 0; i < User; i++)
            {
                invoices.Add("Invoice " + i);

            }

            try
            {
                
                Parallel.For(0, invoices.Count, (indexcount) =>
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    System.Threading.Thread.Sleep(50);
                    po.CancellationToken.ThrowIfCancellationRequested();
                });
            }
            catch (OperationCanceledException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }

            Console.WriteLine("Waiting to exit, press any key.");
            Console.Read();

        }
    }
}
