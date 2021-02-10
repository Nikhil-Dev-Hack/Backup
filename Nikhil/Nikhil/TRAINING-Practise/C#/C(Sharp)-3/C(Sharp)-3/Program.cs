using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Enum
    {
        public object Response { get; private set; }

        public void enumaration()
        {
            WriteDay(Day.Sunday);
        }
        void WriteDay(Day d)
        {
            switch (d)
            {
                case Day.Friday:
                    Console.Write("It is Friday");
                    break;
                case Day.Monday:
                    Console.Write("This is Monday");
                    break;
                case Day.Saturday:
                    Console.Write("This is Saturday");
                    break;
                case Day.Sunday:
                    Console.Write("This is Sunday");
                    break;
                case Day.Thursday:
                    Console.Write("This is Thursday");
                    break;
                case Day.Tuesday:
                    Console.Write("This is Tuesday");
                    break;
                case Day.Wednesday:
                    Console.Write("This is Wednesday");
                    break;
            }
        }


    }
}
enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
