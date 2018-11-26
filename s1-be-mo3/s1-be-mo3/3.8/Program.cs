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
            Random rnd = new Random();
            int random = rnd.Next(1, 101); // creates a number between 1 and 12
            int a = (int)Convert.ToInt32(random);
            Console.WriteLine("Wat is uw voornaam? ");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Wat zijn uw tussenvoegsels? ");
            string tv = Console.ReadLine();
            Console.WriteLine("Wat is uw achternaam? ");
            string achternaam = Console.ReadLine();
            Console.Clear();
            Console.Write(voornaam +tv+ achternaam+a);
            Console.ReadLine();

        }
    }
}