//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.IO;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharpCodingStandard
//{
//    class ParallelProgramming
//    {

//        public void SimpleParallelLoop()
//        {
//            IList<string> invoices = new List<string>();

//            for (var i = 0; i < 10000; i++)
//            {
//                invoices.Add("Invoice " + i);

//            }

//            DateTime timeS = DateTime.Now;
//            foreach (var invoice in invoices)
//            {
//                // processing the invoice
//                Console.WriteLine(invoice);
//            }
//            DateTime timeE = DateTime.Now;
//            Console.WriteLine(timeE - timeS);
//            // Use ParallelOptions instance to store the CancellationToken
//            ParallelOptions po = new ParallelOptions();
//            po.MaxDegreeOfParallelism = 2;

//            Parallel.ForEach(invoices, po, invoice =>
//            {
//                Console.WriteLine(invoice);
//            });
//        }
//        // More than one task can run and wait for all to proceed further
//        public void RunMoreThanOneTaskAndWaitForAll()
//        {
//            var list = new ConcurrentBag<string>();

//            string[] dirNames = { ".", "../../" };
//            List<Task> tasks = new List<Task>();
//            foreach (var dirName in dirNames)
//            {
//                Task t = Task.Run(() =>
//                {
//                    foreach (var path in dirNames)
//                    {
//                        list.Add(path);
//                    }
//                });
//                tasks.Add(t);
//            }

//            //TODO: Comment following line and see the difference
//            //Task.WaitAll(tasks.ToArray());

//            foreach (Task t in tasks)
//            {
//                Console.WriteLine("Task {0} Status: {1}", t.Id, t.Status);
//            }

//            Console.WriteLine("List of files \n\r=================");
//            foreach (var file in list)
//            {
//                Console.WriteLine(file);
//            }

//            Console.WriteLine("Number of files read: {0}", list.Count);
//            Console.Read();

//        }

//        public void StoppingParallelProcessingInBetween()
//        {
//            var cts = new CancellationTokenSource();

//            // Use ParallelOptions instance to store the CancellationToken
//            ParallelOptions po = new ParallelOptions();
//            po.CancellationToken = cts.Token;
//            po.MaxDegreeOfParallelism = 2;

//            Console.WriteLine(" Press 'c' to cancel.");
//            // Run a task so that we can cancel from another thread.
//            Task.Factory.StartNew(() =>
//            {
//                if (Console.ReadKey().KeyChar == 'c')
//                    cts.Cancel();
//                Console.WriteLine("\nPress any key to exit");
//            });

//            IList<string> invoices = new List<string>();
//            // populate invoice data
//            for (var i = 0; i < 10; i++)
//            {
//                invoices.Add("Invoice " + i);
//            }


//            try
//            {
//                Parallel.ForEach(invoices, po, invoice =>
//                {
//                    Console.WriteLine(invoice + " processing with thread " + Thread.CurrentThread.ManagedThreadId);
//                    System.Threading.Thread.Sleep(5000);
//                    po.CancellationToken.ThrowIfCancellationRequested();
//                });
//            }
//            catch (OperationCanceledException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            catch (Exception ee)
//            {
//                Console.WriteLine(ee.ToString());
//            }

//            Console.WriteLine("Waiting to exit, press any key.");
//            Console.Read();
//        }

//        public void BreakOrStopParallelLoop()
//        {
//            // Use ParallelOptions instance to store thread count
//            ParallelOptions po = new ParallelOptions();
//            po.MaxDegreeOfParallelism = 3;

//            IList<string> invoices = new List<string>();
//            // populate invoice data
//            for (var i = 0; i < 10; i++)
//            {
//                invoices.Add("Invoice " + i);
//            }

//            Parallel.ForEach(invoices, po, (invoice, loopState) =>
//            {
//                try
//                {
//                    // Do some work
//                    Console.WriteLine(invoice + " processing with thread " + Thread.CurrentThread.ManagedThreadId);
//                    if (invoice.Equals("Invoice 5"))
//                    {
//                        // visit https://stackoverflow.com/questions/12571048/break-parallel-foreach for more details explanations between Break and Stop
//                        // Completes all iterations of all threads that are prior to the 
//                        // current iterations and then exit the loop
//                         //loopState.Break();

//                        // Stop all iterations as soon as convenient
//                        loopState.Stop();
//                        // throw new ArgumentException("Error occured at 5");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex);

//                    //System.Threading.Thread.Sleep(5000);

//                }

//            });

//            Console.WriteLine("Waiting to exit, press any key.");
//            Console.Read();
//        }

//        public void ErrorHandlingInParallelProcessing()
//        {
//            // Use ParallelOptions instance to store thread count
//            ParallelOptions po = new ParallelOptions();
//            po.MaxDegreeOfParallelism = 5;

//            IList<string> invoices = new List<string>();
//            // populate invoice data
//            for (var i = 0; i < 10; i++)
//            {
//                invoices.Add("Invoice " + i);
//            }

//            try
//            {
//                var exceptions = new ConcurrentBag<Exception>();

//                Parallel.ForEach(invoices, po, invoice =>
//                {
//                    try
//                    {
//                        Console.WriteLine(invoice + " processing with thread " + Thread.CurrentThread.ManagedThreadId);
//                        //System.Threading.Thread.Sleep(5000);
//                        throw new ArgumentException(invoice + " throwing exception.");
//                    }
//                    catch (Exception ee)
//                    {
//                        exceptions.Add(ee);
//                    }
//                });


//                // count and throw all exceptions
//                if (exceptions.Count > 0)
//                {
//                    throw new AggregateException(exceptions);
//                }
//            }
//            catch (AggregateException ex)
//            {
//                foreach (var ee in ex.InnerExceptions)
//                {
//                    Console.WriteLine(ee.Message);
//                }
//            }
//            catch (Exception ee)
//            {
//                Console.WriteLine(ee.ToString());
//            }

//            Console.WriteLine("Waiting to exit, press any key.");
//            Console.Read();
//        }
//    }
//}
