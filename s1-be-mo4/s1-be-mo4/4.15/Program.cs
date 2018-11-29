using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //de score opstellen en variabelen maken
            Console.WriteLine("voer uw score in voor wiskunde 0 t/m 100: ");
            string  wis = Convert.ToString(Console.ReadLine());
            if(wis == string.Empty)
            {
                Console.WriteLine("U heeft niks ingevuld. Als dit cijfer ontbreekt vul een '0' in. ");
            }
            Console.WriteLine("voer uw score in voor Natuurkunde 0 t/m 100: ");
            string nat = Convert.ToString(Console.ReadLine());
            Console.WriteLine("voer uw score in voor Scheikunde 0 t/m 100: ");
            string sch = Convert.ToString(Console.ReadLine());
            int wis1 = Convert.ToInt32(wis);
            int nat1 = Convert.ToInt32(nat);
            int sch1 = Convert.ToInt32(sch);
            int ts = wis1 + nat1 + sch1;

            // if statement met int
            if (wis1 > 100 || nat1 > 100 || sch1 > 100)
            {
                Console.WriteLine("deze score bestaat niet probeer het nogeen keer");
                Console.ReadLine();
            }
            else
            {
                if (wis1 >= 60 && nat1 >= 60 && sch1 >= 60 || ts >= 180)
                {
                    Console.WriteLine("u mag deelnemen aan het examen");
                    Console.ReadLine();
                }
                if (wis1 < 40 || nat1 < 40 || sch1 < 40)
                {
                    Console.WriteLine("u mag niet deelnemen aan het examen");
                    Console.ReadLine();
                }

                if (wis1 == 0 || nat1 == 0 || sch1 == 0)
                {
                    Console.WriteLine("u mag niet deelnemen aan het examen");
                    Console.ReadLine();
                }
            }
        }
    }
}
