using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //een automorf is een getal (6) wat in het kwadraat 6(2) 
            //input
            Console.WriteLine("wat is je getal: ");
            string getal = Console.ReadLine();
            int getal2 = Convert.ToInt32(getal);
            int power = getal2 * getal2;
            int uitkomst = (power % 10);
            //input
            if (uitkomst == getal2)
            {
                Console.WriteLine(getal2 + " is een automorf");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(getal2 + " is geen automorf");
                Console.ReadLine();
            }
        }
    }
}
