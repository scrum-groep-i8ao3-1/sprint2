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
            //invoer van gegevens
            Console.Write("Voer uw studienummer in: ");
            int nummer = Convert.ToInt32(Console.ReadLine());
            Console.Write("voer uw naam in: ");
            var naam = Console.ReadLine();
            Console.Write("voer uw achternaam in: ");
            var achternaam = Console.ReadLine();
            Console.Write("cijfer 1 voor NED: ");
            decimal NED1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 2 voor NED: ");
            decimal NED2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 1 voor ENG: ");
            decimal ENG1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 2 voor ENG: ");
            decimal ENG2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 1 voor WIS: ");
            decimal Wis1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 2 voor WIS: ");
            decimal WIS2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 1 voor PRG: ");
            decimal PRG1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 2 voor PRG: ");
            decimal PRG2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 1 voor DBD: ");
            decimal DBD1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 2 voor DBD: ");
            decimal DBD2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 1 voor ALG: ");
            decimal ALG1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("cijfer 2 voor ALG: ");
            decimal ALG2 = Convert.ToDecimal(Console.ReadLine());

            //variabelen voor gemidelde
            decimal GNED, GENG, GWIS, GPRG, GDBD, GALG;

            //berekeningen 
            GNED = (NED1 + NED2) / 2;
            GNED = Math.Round(GNED, 1);
            GENG = (ENG1 + ENG2) / 2;
            GENG = Math.Round(GENG, 1);
            GWIS = (Wis1 + WIS2) / 2;
            GWIS = Math.Round(GWIS, 1);
            GPRG = (PRG1 + (PRG2 * 2)) / 3;
            GPRG = Math.Round(GPRG, 1);
            GDBD = (DBD1 + (DBD2 * 2)) / 3;
            GDBD = Math.Round(GDBD, 1);
            GALG = (ALG1 + (ALG2 * 2)) / 3;
            GALG = Math.Round(GALG, 1);

            //raport 
            Console.WriteLine(nummer);
            Console.WriteLine("naam  " + naam + ' ' + achternaam);
            Console.WriteLine("cijfers NED   " + NED1 + ' ' + NED2 + ' ' + "gemiddelde " + GNED);
            Console.WriteLine("cijfers ENG   " + ENG1 + ' ' + ENG1 + ' ' + "gemiddelde " + GENG);
            Console.WriteLine("cijfers WIS   " + Wis1 + ' ' + WIS2 + ' ' + "gemiddelde " + GWIS);
            Console.WriteLine("cijfers PRG   " + PRG1 + ' ' + PRG2 + ' ' + "gemiddelde " + GPRG);
            Console.WriteLine("cijfers DBD   " + DBD1 + ' ' + DBD2 + ' ' + "gemiddelde " + GDBD);
            Console.WriteLine("cijfers ALG   " + ALG1 + ' ' + ALG2 + ' ' + "gemiddelde " + GALG);
            Console.ReadLine();
        }
    }
}