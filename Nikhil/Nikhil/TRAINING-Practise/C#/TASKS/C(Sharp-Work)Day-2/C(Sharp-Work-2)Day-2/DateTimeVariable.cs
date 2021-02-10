using System;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Work_2_Day_2
{
    class DateTimeVariable
    {
        /// <summary>
        /// Print only Date 
        /// </summary>
        public void Execute()
        {
            Task task = Task.Run(() =>
            {
                string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                Console.WriteLine("The current date is {0}", date);
            }
            );
            
        }
    }
}

