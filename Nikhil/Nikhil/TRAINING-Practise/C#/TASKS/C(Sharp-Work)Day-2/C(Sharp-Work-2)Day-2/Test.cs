using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Work_2_Day_2
{
    public class Test
    {
        public void StoppingParallelProcessingInBetween()
        {
            var cts = new CancellationTokenSource();

            // Use ParallelOptions instance to store the CancellationToken
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;
            po.MaxDegreeOfParallelism = 3;

            Console.WriteLine(" Press 'c' to cancel.");
            // Run a task so that we can cancel from another thread.
            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar == 'c')
                    cts.Cancel();
                Console.WriteLine("\nPress any key to exit");
            });

            IList<string> invoices = new List<string>();
            // populate invoice data
            for (var i = 0; i < 10000; i++)
            {
                invoices.Add("Invoice " + i);
            }

            try
            {
                Parallel.ForEach(invoices, po, invoice =>
                {
                    Console.WriteLine(invoice + " processing with thread " + Thread.CurrentThread.ManagedThreadId);
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
