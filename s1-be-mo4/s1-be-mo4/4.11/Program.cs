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
            Console.WriteLine("geef nummer van de maand");
            int maand = Convert.ToInt32(Console.ReadLine());
            if (maand == 1)
            {
                Console.WriteLine("31 januari ");
            }
            else if (maand == 2)
            {
                Console.WriteLine("28/29 februari in een schrikkeljaar heeft4" +
                    " het 1 dag meer");
            }
            else if (maand == 3)
            {
                Console.WriteLine("31 maart");
            }
            else if (maand == 4)
            {
                Console.WriteLine("30 april");
            }
            else if (maand == 5)
            {
                Console.WriteLine("31 mei");
            }
            else if (maand == 6)
            {
                Console.WriteLine("30 juni");
            }
            else if (maand == 7)
            {
                Console.WriteLine("31 juli");
            }
            else if (maand == 8)
            {
                Console.WriteLine("31 augustus");
            }
            else if (maand == 9)
            {
                Console.WriteLine("30 september");
            }
            else if (maand == 10)
            {
                Console.WriteLine("31 oktober");
            }
            else if (maand == 11)
            {
                Console.WriteLine("30 november");
            }
            else if (maand == 12)
            {
                Console.WriteLine("31 december");
            }
            else
            {
                Console.WriteLine("dat is geen datum");


            }
            Console.ReadKey();
        }
    }
}

}
