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

        static void Main(string[] args)
        {
            Console.WriteLine("geef mij een zin:  ");
            string str = Console.ReadLine();
            int ctr = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    ctr++;
                }
            }
            Console.WriteLine(ctr);
            Console.ReadLine();
        }
    }
}

