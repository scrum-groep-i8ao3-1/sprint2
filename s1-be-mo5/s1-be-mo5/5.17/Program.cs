using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // revers string 
            string input = string.Empty;
            string reverse = string.Empty;

            //de invoer van de gebruiker 
            Console.WriteLine("schrijf hier een woord of een zin:  ");
            input = Console.ReadLine();

            for (int e = input.Length - 1; e >= 0; e--)
                reverse += input[e];

            // de uitvoer reverse woord of zin 
            Console.WriteLine("dit is jouw woord of zin achterstevoren: " + reverse);
            Console.ReadKey();

        }
    }
}