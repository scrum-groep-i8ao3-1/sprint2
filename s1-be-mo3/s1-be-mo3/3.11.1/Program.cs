using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //jaar
            DateTime huidigetijd = DateTime.Now;
            string jaar = huidigetijd.Year.ToString();
            Console.WriteLine("het jaar is "+jaar);
            //af en werkt
            //jaar
            //maand
            string maand = DateTime.Now.ToString("MMMM");
            Console.WriteLine("de maand is "+maand);
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
            //einde read */all
            Console.Read();
            //einde read */all
        }
    }
}
