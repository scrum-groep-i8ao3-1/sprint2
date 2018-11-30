using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("getal 1: ");
            string g1 = Console.ReadLine();
            Console.WriteLine("getal 2: ");
            string g2 = Console.ReadLine();
            Console.WriteLine("getal 3: ");
            string g3 = Console.ReadLine();
            int g4 = (int)Convert.ToInt32(g1);
            int g5 = (int)Convert.ToInt32(g2);
            int g6 = (int)Convert.ToInt32(g3);
            if (g4 == g5 && g5 == g6)
            {
                Console.Write("alles is gelijk aan elkaar");
                Console.Read();
            }
            if (g6 < g5 && g6 < g4)
            {
                Console.Write("getal 3 is het kleinst");
                Console.Read();
            }
            else
            {
                Console.Write("getal 3 is niet het kleinst");

                Console.Read();
            }
        }
    }
}
