using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._18
{
    class Program
    {
        static void Main(string[] args)
        {
            // e-mail lezen en checken op valide symbolen \
            string s1 = Console.ReadLine();
            string s2 = "@";
            string s3 = ".";
            bool b = s1.Contains(s2);
            bool c = s1.Contains(s3);
            if (b && c)
            {
                int index = s1.IndexOf(s2);
                int index2 = s1.IndexOf(s3);
                // checken op goede volgorde \
                if (index >= 1 && index2 > index)
                    Console.WriteLine("Uw E-mail is geldig. ");
                    else
                    Console.WriteLine("Dit mail adress " + s1 + " is niet geldig. ");
            }
            else
                Console.WriteLine("Dit mail adress " + s1 + " is niet geldig. ");
            Console.ReadLine();
        }
    }
}