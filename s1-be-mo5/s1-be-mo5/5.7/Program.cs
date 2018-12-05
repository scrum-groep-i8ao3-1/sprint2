using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_8_test
{
    class Program
    {
        static int CountChars(string value)
        {
            int result = 0;
            bool lastWasSpace = false;

            foreach (char c in value)
            {
                if (char.IsWhiteSpace(c))
                {

                    if (lastWasSpace == false)
                    {
                        result++;
                    }
                    lastWasSpace = true;
                }
                else
                {
                    result++;
                    lastWasSpace = false;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Voer je volledige naam in: ");
            string zin = Console.ReadLine();

            zin = zin.Replace(" ", string.Empty);
            int count = CountChars(zin);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}