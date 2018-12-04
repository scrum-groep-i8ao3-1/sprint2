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
                Console.WriteLine("januari");
            }
            else if (maand == 2)
            {
                Console.WriteLine("februari");
            }
            else if (maand == 3)
            {
                Console.WriteLine("maart");
            }
            else if (maand == 4)
            {
                Console.WriteLine("april");
            }
            else if (maand == 5)
            {
                Console.WriteLine("mei");
            }
            else if (maand == 6)
            {
                Console.WriteLine("juni");
            }
            else if (maand == 7)
            {
                Console.WriteLine("juli");
            }
            else if (maand == 8)
            {
                Console.WriteLine("augustus");
            }
            else if (maand == 9)
            {
                Console.WriteLine("september");
            }
            else if (maand == 10)
            {
                Console.WriteLine("oktober");
            }
            else if (maand == 11)
            {
                Console.WriteLine("november");
            }
            else if (maand == 12)
            {
                Console.WriteLine("december");
            }
            else
            {
                Console.WriteLine("dat is geen datum");


            }
            Console.ReadKey();
        }
    }
}

