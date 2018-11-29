using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("noem een getal van 10 tot 20 (in cijfers)");
            string b = Console.ReadLine();
            int d = Convert.ToInt32(b);
            for (int i = 1; i <= d; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("het kwadraat is: "+(i * i));
            }
            Console.ReadKey();
        }
    }
}
