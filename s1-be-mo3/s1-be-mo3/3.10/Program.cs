using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._10
{
    static class Constants
    {
        public const int stopper = 1;
        public const int seconden = 0;
        public const int i = 3;
    }

    public class Program
    {
        public static void Main()
        {
            //startup
            //seconden
            //startup
            while (Constants.i > -1)
            {
                if (Constants.i == 3)
                {
                    writer();
                    Constants.i++;
                }
                if (Constants.stopper == 2)
                {
                    Console.Write(Constants.seconden);
                    Console.ReadKey();
                }
                System.Threading.Thread.Sleep(1000);
                Constants.seconden++;
            }
            //seconden
            //writer
             void writer() {
                Console.WriteLine("wat is u naam: ");
                Console.ReadLine();
                Console.WriteLine("wat is u leeftijd: ");
                Console.ReadLine();
                Constants.stopper++;
                Main();
            }
            //writer
        }
    }
}