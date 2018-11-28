using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deze applicatie laat de uitkomst zien van de getallen 100 t/m 1000 bij elkaar opgeteld.");
            Console.ReadLine();

            int getal1, getal2;

            getal1 = 100;
            getal2 = 1000;
            int totaal = 0;

            for (int i = getal1; i <= getal2; i++)
            {
                totaal += i;
            }
            Console.WriteLine("De uitkomst van alle getallen bij elkaar opgeteld is: " + totaal);
            Console.ReadLine();
        }
    }
}
