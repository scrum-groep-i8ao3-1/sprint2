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
            Console.WriteLine("geef aantal werkuren");
            int werkuren = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hoe oud is het apparaat");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef aantal storingen");
            int storingen = Convert.ToInt32(Console.ReadLine());
            if (werkuren >= 10000)
            {
                Console.WriteLine("hij moet vervangen worden");
            }
            else if (leeftijd >= 7)
            {
                Console.WriteLine("hij moet vervangen worden");
            }
            else if (storingen >= 25)
            {
                Console.WriteLine("hij moet vervangen worden");


            }
            else
            {
                Console.WriteLine("het hoeft niet vervangen te worden");
            }
            Console.ReadKey();
        }
    }
}
