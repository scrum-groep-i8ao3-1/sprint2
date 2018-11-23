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
            //Achtergrond kleur
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            
            //Text
            Console.Write("Voer een bedrag in euro's in: ");
            double euro = Convert.ToDouble(Console.ReadLine());

            //variables
            double pond, dollar, lira, dirham, kroon;
            
            //berekening
            pond =  euro * 0.8849;
            dollar = euro * 1.1347;
            lira = euro * 6.0069;
            dirham = euro * 10.7900;
            kroon = euro * 7.4620;



            //uitkomst
            Console.WriteLine("Uw bedrag in pond = " + pond);
            Console.WriteLine("Uw bedrag in dollar = " + dollar);
            Console.WriteLine("Uw bedrag in lira = " + lira);
            Console.WriteLine("Uw bedrag in dirham = " + dirham);
            Console.WriteLine("Uw bedrag in kroon = " + kroon);
            Console.ReadKey();

        }
    }
}
