using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    public class Timer
    {
        private System.Timers.Timer timer;

        public void Time()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 10000;

            timer.Elapsed += Waste;
        }

        private void Waste(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine();
        }
    }
}
