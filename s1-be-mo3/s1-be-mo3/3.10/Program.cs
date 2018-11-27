using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal tussen de 10 en de 100:  ");
            int Getal = Convert.ToInt32(Console.ReadLine());
            if (Getal < 10 || Getal > 100)
            {
                Console.WriteLine("dit is niet het getal dat werd gevraagt ");
            }
            

        }
    }
}
