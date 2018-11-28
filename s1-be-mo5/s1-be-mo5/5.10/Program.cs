using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("voer een getal van 10 tot honderd in (in cijfers)");
            string t = Console.ReadLine();
            int d = Convert.ToInt32(t);
            int totaal = 0;
            for (int i = 1;i <= d; i++)
            {
                if (i % 2 == 1)
                {
                    totaal += i;
                    string output = i.ToString();
                    Console.WriteLine(output);
                }
            }
            Console.Write("het totaal is:"+totaal);
            Console.ReadKey();
        }
        }
    }
