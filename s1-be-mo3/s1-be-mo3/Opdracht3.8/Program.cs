using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._8
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Wat is uw voornaam? ");
            var voornaam = Console.ReadLine();

            string var;
            var = voornaam;
            int count = 0;
            Console.WriteLine("Wat is/zijn uw tussenvoegsels?(aan elkaar) ");
            var tussen = Console.ReadLine();

            string voegsel;
            voegsel = tussen;
            Console.WriteLine("Wat is uw achternaam? ");
            var achternaam = Console.ReadLine();

            string achter;
            achter = achternaam;
            var naam = voornaam + tussen + achternaam;

            string name;
            name = naam;
            for (int i = 0; i < naam.Length; i++)

            {
                count++;
            }
            string sub = voornaam.Substring(0, 1);
            string eerste = sub.ToLower();
            string lower = achternaam.ToLower();
            Console.WriteLine("Uw Wachtwoord = {0}{1}"+ count, eerste, lower);
            Console.ReadLine();
        }
    }
}
