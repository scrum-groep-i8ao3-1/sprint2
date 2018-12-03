using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._20
{
    class Program
    {
        static void Main(string[] args)
        {
            //vraag getal
            Console.WriteLine("voer een getal van 10 tot 1 miljoen in: ");
            string TienTotMiljoen = Console.ReadLine();  // maak string van getal
            int cijfer = Convert.ToInt32(TienTotMiljoen); //maak int van getal
            int tiener = Convert.ToInt32(TienTotMiljoen);
            int TienTotMiljoen2 = tiener * 10000000;
            string TienTotMiljoen3 = Convert.ToString(TienTotMiljoen2);
            int count = TienTotMiljoen3.Length; // telt hoeveel characters een itn heeft (100 = 3 : 2000 = 4)
            //kijkt alle cijfers
                string x1 = TienTotMiljoen3.Substring(0, 1);
                string x2 = TienTotMiljoen3.Substring(1, 1);
                string x3 = TienTotMiljoen3.Substring(2, 1);
                string x4 = TienTotMiljoen3.Substring(3, 1);
                string x5 = TienTotMiljoen3.Substring(4, 1);
                string x6 = TienTotMiljoen3.Substring(5, 1);
                string x7 = TienTotMiljoen3.Substring(6, 1);
            // kijkt alle cijfers (string (variable)= TienTotMiljoen.Substring(positie), 1);
            //convertatie
                int c1 = Convert.ToInt32(x1);
                int c2 = Convert.ToInt32(x2);
                int c3 = Convert.ToInt32(x3);
                int c4 = Convert.ToInt32(x4);
                int c5 = Convert.ToInt32(x5);
                int c6 = Convert.ToInt32(x6);
                int c7 = Convert.ToInt32(x7);
            //converattie
            //vermenevuldingen
            int v1 = c1 * c1;
            int v2 = c2 * c2 * c2;
            int v3 = c3 * c3 * c3 * c3;
            int v4 = c4 * c4 * c4 * c4 * c4;
            int v5 = c5 * c5 * c5 * c5 * c5 * c5;
            int v6 = c6 * c6 * c6 * c6 * c6 * c6;
            int v7 = c7 * c7 * c7 * c7 * c7 * c7 * c7;
            int totaal = v1 + v2 + v3 + v4 + v5 + v6 + v7;
            //vermenevuldigingen

            //convertatie
            Console.WriteLine(totaal);
            Console.ReadKey();
            //string x = TienTotMiljoen.Substring(b, 1); x = hier kotm de string b + 1 om verder te gaan

        }
    }}
