using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kies een nummer 1 t/m 4:");
           int getal = Convert.ToInt32(Console.ReadLine());

            if (getal == 1)
            {
                Console.WriteLine("Klaveren");
            }
            else if (getal ==2)
            {
                Console.WriteLine("Ruiten");
            }
            else if (getal == 3)
            {
                Console.WriteLine("Harten");
            }
            else if (getal == 4)
            {
                Console.WriteLine("Schoppen");
            }
            else if (getal >= 5)
            {
                Console.WriteLine("Geen geldige waarde.");
            }
            Console.ReadKey();
        }
    }
}
