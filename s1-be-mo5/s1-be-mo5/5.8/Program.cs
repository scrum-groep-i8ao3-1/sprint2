using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabelen 
            int oud = 0;
            int nieuw = 1;
            int nieuwnieuw = 0;
            int bijH = 0;



            // nieuw en oud omzetten en het antwoord laten zien 
            while (bijH != 25)
            {
                bijH = bijH + 1;
                nieuwnieuw = oud += nieuw;
                oud = nieuw;
                nieuw = nieuwnieuw;
                Console.WriteLine(nieuwnieuw);
                Console.ReadLine();
            }
        }
    }
}
