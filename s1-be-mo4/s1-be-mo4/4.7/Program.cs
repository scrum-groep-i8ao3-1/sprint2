using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            var day = DateTime.Now.DayOfWeek;
            

            if (now.Hour < 12 && now.Hour > 0 && day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Thursday || day == DayOfWeek.Wednesday || day == DayOfWeek.Friday )
            {
                Console.WriteLine("Goedemorgen het is vandaag een werkdag");
                Console.ReadLine();
            }

            if (now.Hour > 12 && now.Hour < 18 && day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Thursday || day == DayOfWeek.Wednesday || day == DayOfWeek.Friday)
            {
                Console.WriteLine("Goedemiddag het is vandaag een werkdag");
                Console.ReadLine();
            }

            if (now.Hour > 12 && now.Hour < 18 && day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                Console.WriteLine("Goedemiddag het is vandaag weekend");
                Console.ReadLine();
            }

            if (now.Hour < 12 && now.Hour > 0 && day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                Console.WriteLine("Goedemorgen het is vandaag weekend");
                Console.ReadLine();
            }

            if (now.Hour < 24 && now.Hour > 18 && day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                Console.WriteLine("Goedenavond het is vandaag weekend");
                Console.ReadLine();
            }

            if (now.Hour < 24 && now.Hour > 18 && day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Thursday || day == DayOfWeek.Wednesday || day == DayOfWeek.Friday)
            {
                Console.WriteLine("Goedenavond het is vandaag een werkdag");
                Console.ReadLine();
            }
        }
    }
}
