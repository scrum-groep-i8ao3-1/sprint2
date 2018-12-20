using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._19
{
    class Program
        //nagekeken door danny
        //gemaakt door kevin / danny /tom /daniel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("voer graden in: ");
            string graden = Console.ReadLine();
            Console.Clear();
            int graden2 = Convert.ToInt32(graden);
            int gradenvoer = -30;
            int plusser = 1;
            while (gradenvoer <= 50)
            {
                if( gradenvoer == -30 && gradenvoer <= -20)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                if (gradenvoer == -20 && gradenvoer <= -10)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                if (gradenvoer == -10 && gradenvoer <= -0)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                if (gradenvoer == 0 && gradenvoer <= 10)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                if (gradenvoer == 10 && gradenvoer <= 20)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                if (gradenvoer == 20 && gradenvoer <= 30)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                if (gradenvoer == 30 && gradenvoer <= 50)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                if(gradenvoer > graden2)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                String i = "i";
                i = i.Replace("i", "_");
                Console.Write(i);
                gradenvoer += plusser;
            }
            Console.ReadKey();
        }
    }
}