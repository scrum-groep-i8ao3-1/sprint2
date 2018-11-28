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
            DateTime dt = DateTime.Parse("07:00:00 AM");

            dt.ToString("HH:mm");
            dt.ToString("hh:mm tt"); 
            dt.ToString("H:mm"); 
            dt.ToString("h:mm tt");
            Console.WriteLine(dt);
            Console.ReadLine();

        }
    }
}
