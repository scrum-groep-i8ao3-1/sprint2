using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
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
            var laatstedag = DateTime.DaysInMonth(year, month);
            Console.Write(laatstedag);
            Console.ReadKey();
        }
    }
}
