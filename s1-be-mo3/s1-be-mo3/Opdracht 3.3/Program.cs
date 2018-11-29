using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            decimal hoogte, lengte, breedte,kubus;

            //input
            Console.Write("Voer hoogte in.");
            lengte = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Voer lengte in.");
            breedte = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Voer breedte in.");
            hoogte = Convert.ToDecimal(Console.ReadLine());

            //berekening 
           kubus = lengte * breedte * hoogte;
            kubus = Math.Round(kubus, 2);

            //output
            Console.WriteLine("kubus =" + kubus);
            Console.ReadKey();

        }
    }
}
