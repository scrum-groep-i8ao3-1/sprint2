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
<<<<<<< HEAD
            string s1 = Console.ReadLine();
            string s2 = "@";
            string s3 = ".com";
            string s4 = ".nl";
            bool b = s1.Contains(s2 && s3);
            string s5 = s1;
            bool a = s5.Contains(s2 + s4);
            if(a == true)
            {
                Console.WriteLine("Dit is een geldig mail adress");
                if (b == true)
                {
                    Console.WriteLine("Dit is een geldig mail adress");
                }
                else
                    Console.WriteLine("Dit is GEEN geldig mail adress");
            }
            Console.ReadLine();

        }
    }
}
=======
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
>>>>>>> 7862acb04f685151626a522648c76ed874a9a035
