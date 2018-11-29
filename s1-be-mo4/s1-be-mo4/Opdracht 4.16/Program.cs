using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            //jaar
            DateTime huidigetijd = DateTime.Now;
            string jaar = huidigetijd.Year.ToString();
            Console.WriteLine("het jaar is " + jaar);
            //af en werkt
            //jaar
            //maand
            string maand = DateTime.Now.ToString("MMMM");
            Console.WriteLine("de maand is " + maand);
            //af en werkt
            //maand
            //dag
            string dag = DateTime.Now.ToString("dddd");
            Console.WriteLine("de dag is " + dag);
            //af en werkt
            //dag
            // hoeveelste dag van de maand
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            String dy = datevalue.Day.ToString();
            Console.WriteLine("de dag in nummers is " + dy);
            // hoeveelste dag van de maand
            //week nummer
            int weekNum = DateTime.Now.DayOfYear / 7;
            Console.WriteLine("week nummer is " + weekNum);
            //week nummer
            //dag van jaar
            //dag van jaar
            int dvj = DateTime.Now.DayOfYear;
            Console.WriteLine("de dag van het jaar is " + dvj);
            //Schrikkeljaar
            int year = DateTime.Now.Year;
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Dit jaar is een schrikkeljaar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dit jaar is geen schrikkeljaar.");
            }
            //huidige dag doordeweeks of weekend
            var day = DateTime.Now.DayOfWeek;
            if (day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Thursday || day == DayOfWeek.Wednesday || day == DayOfWeek.Friday)
            {
                Console.WriteLine("Het is vandaag een doordeweekse dag.");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Het is vandaag weekend");
            }
            //einde read */all
            Console.ReadKey();
            //einde read */all
        }
    }
}
