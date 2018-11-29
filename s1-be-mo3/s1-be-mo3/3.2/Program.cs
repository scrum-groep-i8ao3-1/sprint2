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
                Console.WriteLine("31 dagen");
            }
            else if (maand == 2)
            {
                Console.WriteLine("28");
            }
            else if (maand == 3)
            {
                Console.WriteLine("31");
            }
            else if (maand == 4)
            {
                Console.WriteLine("30");
            }
            else if (maand == 5)
            {
                Console.WriteLine("31");
            }
            else if (maand == 6)
            {
                Console.WriteLine("30");
            }
            else if (maand == 7)
            {
                Console.WriteLine("31");
            }
            else if (maand == 8)
            {
                Console.WriteLine("31");
            }
            else if (maand == 9)
            {
                Console.WriteLine("30");
            }
            else if (maand == 10)
            {
                Console.WriteLine("31");
            }
            else if (maand == 11)
            {
                Console.WriteLine("30");
            }
            else if (maand == 12)
            {
                Console.WriteLine("31");
            }
            else
            {
                Console.WriteLine("dat is geen datum");


            }
            Console.ReadKey();
        }
    }
}

