using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elections
{
    public class ElectionCancellation
    {
        public void StopingTheProcess()
        {
            var cts = new CancellationTokenSource();

            ParallelOptions po = new ParallelOptions();
            po.MaxDegreeOfParallelism = 2;
            po.CancellationToken = cts.Token;

            Console.WriteLine("Press 'c' to terminate the Elections");

            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar =='c')
                {
                    cts.Cancel();
                }
            });
            Test test = new Test();
            test.Parties();

            Parallel.ForEach()
        }
    }
}
