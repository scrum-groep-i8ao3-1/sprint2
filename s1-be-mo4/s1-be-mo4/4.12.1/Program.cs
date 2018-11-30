using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Voer uw datum zo in: DD/MM/YYYY  ");
            string dtm = Console.ReadLine();
            DateTime datum = DateTime.Parse(dtm);
            var year = datum.Year;
            var month = datum.Month;
            var day = datum.Day;
            DateTime monthStart = new DateTime(year, month, 1);
            string myStringDate = monthStart.ToString();
            string xx = System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.GetDayName(DateTime.Parse(myStringDate).DayOfWeek);
            Console.WriteLine(xx);
            Console.ReadLine();
        }
    }
}
