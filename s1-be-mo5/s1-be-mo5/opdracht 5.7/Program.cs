using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int worpen = 0;
            for (int punten = 0; punten < 1000; worpen++)
            {
                int random2 = random.Next(1, 6);
                punten += random2;
                worpen += 1;
            }
            Console.WriteLine(worpen);
            Console.ReadKey();
        }
    }
}
