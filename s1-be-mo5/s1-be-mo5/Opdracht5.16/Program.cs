using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._16
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Voer een woord in.:");
            string input = Console.ReadLine();
            //uitwerking
            char[] chars = input.ToCharArray();
            for (int hoofdletter = 1; hoofdletter < chars.Length; hoofdletter += 2)
            {
                chars[hoofdletter] = char.ToUpper(chars[hoofdletter]);
            }
            //output
            string output = new string(chars);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
