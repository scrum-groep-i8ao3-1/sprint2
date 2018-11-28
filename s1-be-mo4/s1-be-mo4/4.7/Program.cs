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
            DateTime day = DateTime.Now;
            Console.WriteLine(day.DayOfWeek);

            if (now.Hour < 12 && now.Hour > 0)
            {
                Console.WriteLine("Goedemorgen het is vandaag een werkdag");
                Console.ReadLine();
            }

            if (now.Hour > 12 && now.Hour < 18)
            {
                Console.WriteLine("Goedemiddag het is vandaag weekend");
                Console.ReadLine();
            }

            if (now.Hour < 24 && now.Hour > 18)
            {
                Console.WriteLine("Goedenavond het is vandaag een werkdag");
                Console.ReadLine();
            }
        }
    }
}
