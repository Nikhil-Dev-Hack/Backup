using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpCodingStandard
{

    //======================================
    class Program
    {
      
        public static void Main()
        {
            ParallelProgramming p = new ParallelProgramming();
            //p. SimpleParallelLoop();
            //p.StoppingParallelProcessingInBetween();
            //p.BreakOrStopParallelLoop();
            p.ErrorHandlingInParallelProcessing();
            //p.RunMoreThanOneTaskAndWaitForAll();
           // ParallelWithCancellation parallelWithCancellation = new ParallelWithCancellation();
           // parallelWithCancellation.ParallelWithCancel();

        }

    }
}
