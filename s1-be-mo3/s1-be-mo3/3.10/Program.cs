using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._10
{
    static class Constants
    {
    }

    public class Program
    {
        public static void Main()
        {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Console.WriteLine("wat is u naam: ");
                Console.ReadLine();
                Console.WriteLine("wat is u leeftijd: ");
                Console.ReadLine();
                watch.Stop();
                TimeSpan elapsedS = watch.Elapsed;
            Console.WriteLine("U heeft er zolang over gedaan: " + elapsedS);
            Console.ReadLine();
            }
            //writer
        }
    }