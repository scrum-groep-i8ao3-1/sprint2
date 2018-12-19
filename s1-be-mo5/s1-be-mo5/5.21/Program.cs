using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double getI = 0;
            double getT = 0;
            double antw = 0;
            Console.Write("dit is een programma die alle getalen die een veelvoud zijn van 3 of 5 bij elkaar optelt, dit doet het met alle getallen onder de 1000 ");
            Console.ReadLine();

            for (double i = 1; i <= 1000; i++ )
            {
                double t = i;
                getI = i % 3;
                getT = t % 5;
                if (getT == 0 )
                    {
                    antw = antw + t;
                    }
                if (getI == 0)
                {
                    antw = antw + i;
                }
            }
                Console.WriteLine(antw);
                Console.ReadLine();
            }
            
        }
    }

