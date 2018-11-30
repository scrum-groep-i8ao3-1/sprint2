using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("getal 1: ");
            string g1 = Console.ReadLine();
            Console.WriteLine("getal 2: ");
            string g2 = Console.ReadLine();
            int g3 = (int)Convert.ToInt32(g1);
            int g4 = (int)Convert.ToInt32(g2);
            if (g3 == g4)
            {
                Console.Write("de getallen zijn gelijk aan elkaar");
                Console.ReadKey();
            }
            if (g3 < g4)
            {
                Console.Write("getal 2 is het grooste");
                Console.ReadKey();
            }
            if (g3 > g4)
            {
                Console.Write("getal 1 is het grootste");
                Console.ReadKey();
            }

        }
    }
}
