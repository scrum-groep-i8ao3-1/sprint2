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
            // e-mail lezen en checken op valide symbolen \\
            string s1 = Console.ReadLine();
            string s2 = "@";
            bool b = s1.Contains(s2);
            bool c = s1.EndsWith(".com");
            bool d = s1.EndsWith(".");
            string be = ".be";
            bool e = s1.Contains(be);
            string de = ".de";
            bool f = s1.Contains(de);
            if (b && c || b && d || b && e || b && f)
            {
                int index = s1.IndexOf(s2);
                // checken op goede volgorde \\
                if (index >= 1)
                   Console.WriteLine("Uw E-mail is geldig. ");
            }
            else
                Console.WriteLine("Dit mail adress " + s1 + " is niet geldig. ");
                            Console.ReadLine();
        }
    }
}