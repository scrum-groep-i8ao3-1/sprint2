using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een willekeurig getal in: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voer een willekeurig getal in: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            for (int i = getal1 + 1; i < getal2; i++)
            {
                Console.WriteLine(i);
            }
                Console.ReadKey();

            if (getal1 > getal2)
            {
                for (int b = getal1 - 1; b > getal2; b--)
                {
                    Console.WriteLine(b);
                }
                Console.ReadKey();
            }

            if (getal1 == getal2)
            {
                Console.WriteLine("Hier zitten geen verdere getallen tussen.");
                Console.ReadKey();
            }
        }
    }
}
