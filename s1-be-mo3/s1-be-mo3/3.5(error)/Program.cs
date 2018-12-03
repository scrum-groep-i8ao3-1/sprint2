using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    class Program
    {
        private const double V = 1.50;

        static void Main(string[] args)
        {
            Console.WriteLine("Geef de lengte van uw camper in meter: ");
            double lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef de breedte van uw camper in meter: ");
            double breedte = Convert.ToDouble(Console.ReadLine());
            double vm = lengte * breedte;
            double jaar = vm * 12 * V;
            double jaar2 = vm * 24 * V / 100 * 95;
            double jaar3 = vm * 36 * V / 100 * 90;
            Console.WriteLine("De stalling voor 1 jaar in euro is: " + jaar);
            Console.WriteLine("De stalling voor 2 jaar in euro is: " + jaar2);
            Console.WriteLine("De stalling voor 3 jaar in euro is: " + jaar3);
            Console.ReadKey();
        }
    }
}

