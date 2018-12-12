using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            double geld, rente, rente2, antwoord, antwoord2;
            int jaar;
            jaar = 1;
            Console.WriteLine("Geef geld bedrag");
            geld = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef rente in procent ");
            rente = Convert.ToDouble(Console.ReadLine());
            rente2 = 100 + rente;
            antwoord = (geld / 100 * rente2);
            antwoord2 = (geld / 100 * rente2);

            while (jaar <= 9)
            {
                Console.WriteLine("jaar " + jaar + " heeft winst van van" + antwoord);
                antwoord = antwoord / 100 * rente2;
                double berekening = antwoord - antwoord2;

                jaar++;
            }
            Console.Read();


        }
    }
}
