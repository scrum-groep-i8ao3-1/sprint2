using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("voer graden in: ");
            string graden = Console.ReadLine();
            Console.Clear();
            int graden2 = Convert.ToInt32(graden);
            int gradenvoer = -30;
            int plusser = 1;
            while (gradenvoer <= graden2)
            {
                if( gradenvoer == -30 && gradenvoer <= -20)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                if (gradenvoer == -20 && gradenvoer <= -10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                if (gradenvoer == -10 && gradenvoer <= -0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                if (gradenvoer == 0 && gradenvoer <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (gradenvoer == 10 && gradenvoer <= 20)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (gradenvoer == 20 && gradenvoer <= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (gradenvoer == 30 && gradenvoer <= 50)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.WriteLine(gradenvoer);
                gradenvoer += plusser;
            }
            Console.ReadKey();
        }
    }
}
