using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef je punten");
            int punten = Convert.ToInt32(Console.ReadLine());
            if (punten <= 50)
            {
                Console.WriteLine("F. je hebt een onvoldoende ");
            }
            else if (punten <= 60)
            {
                Console.WriteLine("D. je hebt een voldoende");
            }
            else if (punten <= 65)
            {
                Console.WriteLine("D+. je hebt een voldoende");
            }
            else if (punten <= 70)
            {
                Console.WriteLine("C. je hebt een voldoende");
            }
            else if (punten <= 75)
            {
                Console.WriteLine("C+. je hebt een voldoende");
            }
            else if (punten <= 80)
            {
                Console.WriteLine("B. je hebt een voldoende");
            }
            else if (punten <= 85)
            {
                Console.WriteLine("B+. je hebt een voldoende");
            }
            else if (punten <= 90)
            {
                Console.WriteLine("A. je hebt een voldoende");
            }
            else if (punten <= 100)
            {
                Console.WriteLine("A+. je hebt een voldoende");
            }
            else
            {
                Console.WriteLine("dat is niet geldig ");
            }
            Console.ReadKey();
        }
    }
}
