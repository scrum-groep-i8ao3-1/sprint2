using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            string reverse = String.Empty;

            //Input
            Console.WriteLine("geef mij een woord:  ");
            string str = Console.ReadLine();
           
            //Spaties bij elkaar optellen
            int ctr = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    ctr++;
                }
            }
            //tekens optellen
            int txt = 0;

            for (int t = 0; t < str.Length; t++)
                {
                    txt++;
                }
           
            //tekens zonder spaties
            int tekens = txt - ctr;
           
            //Max aantal tekens
            if (tekens > 25)
            {
                Console.WriteLine("De zin is te lang het maximum aantal tekens is 25.");
            }
            Console.ReadLine();
           
            //uitkomst
            if (tekens <= 25)
            {
                for (int e = str.Length - 1; e >= 0; e--)
                    reverse += str[e];
                Console.WriteLine(reverse);
                Console.ReadLine();
            }
            if (str == reverse)
            {
                Console.WriteLine("Dit woord is een palindroom");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dit woord is geen palindroom");
                Console.ReadLine();
            }
        }
    }
}
