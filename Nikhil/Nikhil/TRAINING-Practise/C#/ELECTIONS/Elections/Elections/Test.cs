using System;
using System.Collections.Generic;
using System.Text;

namespace Elections
{
    class Test
    {
        float T = 0, C = 0, B = 0, N = 0, I = 0;
        float t, c, b, n, i;
        float Users;
        public void Parties()
        {
            Console.WriteLine("Enter Number Of Voters");
            Users = int.Parse(Console.ReadLine());

            int TRS = 1, Congress = 2, BJP = 3, Nota = 4;
            Console.WriteLine("TRS:1    Congress:2    BJP:3    Nota:4");
            for (int i = 0; i < Users; i++)
            {

                Console.WriteLine("Please vote");
                var a = int.Parse(Console.ReadLine());
                if (a == TRS)
                {
                    T++;
                }
                else if (a == Congress)
                {
                    C++;
                }
                else if (a == BJP)
                {
                    B++;
                }
                else if (a == Nota)
                {
                    N++;
                }
                else
                {
                    I++;
                }

            }

            Results();
        }
        public void Results()
        {
            Console.WriteLine("TRS Votes:" + T + "-------" + "Congress Votes:" + C + "-------" + "BJP Votes:" + B + "-------" + "Nota:" + N + "-------" + "Invalid:" + I);

            VotingPercentage();
        }

        public void VotingPercentage()
        {
            t = T / Users * 100;
            c = C / Users * 100;
            b = B / Users * 100;
            n = N / Users * 100;
            i = I / Users * 100;
            Console.WriteLine("TRS:" + t + "%" + "   " + "Congress:" + c + "%" + "   " + "BJP:" + b + "%" + "   " + "Nota:" + n + "%" + "   " + "Invalid:" + i + "%");
        }


        
    }
}
