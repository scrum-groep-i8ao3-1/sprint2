using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //getallen opstellen
            Console.WriteLine("geef een getal:  ");
            int gt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef een tweede getal waarvan je wilt weten of het een veelvoud is van het eerste getal:  ");
            int gt2 = Convert.ToInt32(Console.ReadLine());
            int ant = 0;

            //berekenen
            ant = gt2 % gt1;
            if (ant == 0)
            {
                Console.WriteLine("het getal is een veelvoud van getal 1");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("dit is geen veelvoud van getal 1");
                Console.ReadLine();
            }

        }
    }
}
