using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul een geld bedrag in: ");
            int input = Convert.ToInt32(Console.ReadLine());

            double dollar = input * 1.1272;
            double pond = input * 0.8617;
            double afghani = input * 87.4500;
            double lek = input * 123.9500;
            double dinar = input * 134.4460;
            Console.WriteLine("Uw bedrag in dollars: " + dollar);
            Console.WriteLine("Uw bedrag in pond: " + pond);
            Console.WriteLine("Uw bedrag in afghani: " + afghani);
            Console.WriteLine("Uw bedrag in lek: " + lek);
            Console.WriteLine("Uw bedrag in dinar: " + dinar);

            Console.ReadKey();
        }
    }
}