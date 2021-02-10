using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingStandard
{
   public  class encapsulation1
    {
        public void add(int a,int b)
        {
            Console.WriteLine("ADDITION OF {0} AND {1} IS{2}" ,a,b,a+b);
        }
       private void sub(int a, int b)
        {
            Console.WriteLine("subtractionb OF {0} AND {1} IS{2}", a, b, a - b);
        }


     protected void mul(int a, int b)
        {
            Console.WriteLine("subtractionb OF {0} AND {1} IS{2}", a, b, a * b);
        }


    }
}
