using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // de tijd van opstellen
            DateTime time = DateTime.Now;
            Console.WriteLine("{0}:{1}:{2}", time.Hour, time.Minute, time.Second);
            DayOfWeek today = DateTime.Today.DayOfWeek;

            if (time.Hour < 12 && time.Hour > 0 )  
            {
                Console.WriteLine("lekker werken boi");
                Console.ReadLine();
            }
        }
    }
}
