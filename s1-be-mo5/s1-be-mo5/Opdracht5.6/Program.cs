using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._6
{
    class Program
    {
        static void Main(string[] args)
        {

            //var 
            
            Random random = new Random();
            






            // input
            for (int throws = 1; throws <= 5; throws++)
            {
                if (throws == 6)
                {
                    break;
                }

                decimal dice1 = random.Next(1, 7);
                decimal dice2 = random.Next(1, 7);
                decimal dice3 = random.Next(1, 7);
                decimal dice4 = random.Next(1, 7);
                decimal dice5 = random.Next(1, 7);
                decimal totaalworp = dice1 + dice2 + dice3 + dice4 + dice5;
                decimal worpgemiddelde = totaalworp / 5 ;



                // output
                Console.ReadKey();
                Console.WriteLine("Je hebt " + throws + "Keer gegooid");
                Console.WriteLine("Het nummer van dice1 is:" + dice1);
                Console.WriteLine("Het nummer van dice2 is:" + dice2);
                Console.WriteLine("Het nummer van dice3 is:" + dice3);
                Console.WriteLine("Het nummer van dice4 is:" + dice4);
                Console.WriteLine("Het nummer van dice5 is:" + dice5);
                Console.WriteLine("Het totaal van deze worp is:" + totaalworp);
                Console.WriteLine("Het gemiddelde van deze worp is:" + worpgemiddelde );
                Console.ReadLine();







            }
        }
    }
}
