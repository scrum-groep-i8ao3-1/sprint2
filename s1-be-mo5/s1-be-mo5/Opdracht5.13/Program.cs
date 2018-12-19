using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hier voer je de text in
            Console.WriteLine(" Voer hier uw text in.:");
            var input = Console.ReadLine();

            //De var en array's 
            int klinkers, medeKlinkers, cijfers, andereTekens;
            var hsKlinkers = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var hsMedeKlinkers = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            var hsCijfers = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
          
            // Telt of wat er is ingevoert zelfde is als in array's
            klinkers = input.Count(c => hsKlinkers.Contains(c));
            medeKlinkers = input.Count(c => hsMedeKlinkers.Contains(c));
            cijfers = input.Count(c => hsCijfers.Contains(c));
            andereTekens = input.Length - (klinkers + medeKlinkers + cijfers);
            
            //output
            Console.WriteLine("Uw text heeft {0} klinkers, {1} medeklinkers, {2} cijfers en {3} andere tekens.", klinkers, medeKlinkers, cijfers, andereTekens);


            Console.ReadKey();





        }
    }
}



