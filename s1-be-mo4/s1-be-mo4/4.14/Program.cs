using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in: ");
            float getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer nog een getal in: ");
            float getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Typ 1 als u de getallen wilt optellen.");
            Console.WriteLine("Typ 2 als u de getallen wilt aftrekken.");
            Console.WriteLine("Typ 3 als u de getallen wilt vermenigvuldigen.");
            Console.WriteLine("Typ 4 als u de getallen wilt delen.");
            Console.WriteLine("Typ 5 als u het modulus wilt hebben van de getallen.");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                Console.WriteLine("Optellen");
                Console.WriteLine(getal1 + getal2);
            }
            if (keuze == 2)
            {
                Console.WriteLine("Aftrekken");
                Console.WriteLine(getal1 - getal2);
            }
            if (keuze == 3)
            {
                Console.WriteLine("Vermenivuldigen");
                Console.WriteLine(getal1 * getal2);
            }
            if (keuze == 4)
            {
                if (getal1 == 0 || getal2 == 0)
                {
                    Console.WriteLine("Kom op man, Delen door 0 is flauwekul");
                }
                else
                Console.WriteLine("Delen");
                Console.WriteLine(getal2 / getal1);
         
            }
            if (keuze == 5)
            {
                if (getal1 > getal2) {
                Console.WriteLine("Modulus");
                Console.WriteLine(getal1 % getal2);
            }
                else
                {
                    Console.WriteLine("Modulus");
                    Console.WriteLine(getal2 % getal1);
                }
            }
            Console.ReadLine();
        }
    }
}
