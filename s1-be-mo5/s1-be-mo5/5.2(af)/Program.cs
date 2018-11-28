using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 26; i++)
            {
                int ikwadraat = i * i;
                string skwadraat = ikwadraat.ToString();
                Console.WriteLine(skwadraat);
            }
            Console.ReadKey();
        }
    }
}
