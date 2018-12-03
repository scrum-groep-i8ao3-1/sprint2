using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Type een nummer tussen de 1 en de 7: ");
            int weekgetal = Convert.ToInt32(Console.ReadLine());

            if (weekgetal == 1)
            {
                Console.WriteLine("Maandag");
                Console.ReadLine();
            }
            if (weekgetal == 2)
            {
                Console.WriteLine("Dinsdag");
                Console.ReadLine();
            }
            if (weekgetal == 3)
            {
                Console.WriteLine("Woensdag");
                Console.ReadLine();
            }
            if (weekgetal == 4)
            {
                Console.WriteLine("Donderdag");
                Console.ReadLine();
            }
            if (weekgetal == 5)
            {
                Console.WriteLine("Vrijdag");
                Console.ReadLine();
            }
            if (weekgetal == 6)
            {
                Console.WriteLine("Zaterdag");
                Console.ReadLine();
            }
            if (weekgetal == 7)
            {
                Console.WriteLine("Zondag");
                Console.ReadLine();
            }
            if (weekgetal > 7)
            {
                Console.WriteLine("Dit getat is te hoog.");
                Console.ReadLine();
            }
        }
    }
}