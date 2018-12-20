using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11._1
{
    class Program
    {
        //nagekeken door jairo
        //gemaakt door dannylanssink
        static void Main(string[] args)
        {
            //jaar

            DateTime huidigetijd = DateTime.Today;
            string jaar = huidigetijd.Year.ToString();
            Console.WriteLine("het jaar is "+jaar);
            //af en werkt
            //jaar
            //maand
            string maand = DateTime.Now.ToString("MM");
            Console.WriteLine("de maand is "+maand);
            //af en werkt
            //maand
            //dag
            string dag = DateTime.Now.ToString("dd");
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
            int djaar = Convert.ToInt32(jaar);//werkt
            int dmaand = Convert.ToInt32(maand);
            int ddag = Convert.ToInt32(dag);
            var d = new DateTime(djaar, dmaand, ddag);
            CultureInfo cul = CultureInfo.CurrentCulture;
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNumber = ciCurr.Calendar.GetWeekOfYear(d, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            String WeekNumberS = Convert.ToString(weekNumber);
            Console.WriteLine("week number is " + WeekNumberS);
            //week nummer
            //dag van jaar
            int dvj = DateTime.Now.DayOfYear;
            Console.WriteLine("de dag van het jaar is " + dvj);
            //dag van jaar
            //einde read */all
            Console.Read();
            //einde read */all

        }
    }
}
