using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRACTISE
{
    public class PARALLELPROGRAMINGSYNTAX
    {
       public void ParallelOPtionsInParallelProgramming()
        {
            ParallelOptions po = new ParallelOptions();
            po.MaxDegreeOfParallelism = 2;
        }

        public  void ParallelFor()
        {
            Parallel.For(0, 11, (i) =>
            {
                Console.WriteLine("Hello User");
            });
        }

        public void ParallelForeach()
        {
            var ne = new List<int>();
            ne.Add(10);

            Parallel.ForEach(ne, a =>
             { Console.WriteLine(a); });
        }
    }
}
