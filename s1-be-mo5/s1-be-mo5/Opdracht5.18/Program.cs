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
