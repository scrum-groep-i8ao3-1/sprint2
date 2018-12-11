using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //bepaald de grote van de array
            Console.Write("Hoeveel nummers moet de lijst bevatten?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            // bepaald de naam van de array
            int[] numbers = new int[n];
            //zet min en max op 0
            int min = numbers[0]; 
            int max = numbers[0];
            


            // voegt nummers toe tot bepaalde max van de array is bereikt
            for (int numlist = 0; numlist < n; numlist++)
            {
                Console.Write("Voer nummer {0} in:  ", numlist + 1);
                numbers[numlist] = Convert.ToInt32(Console.ReadLine());
                
            }
            // Bepaald de max en min van de array

            for (int numlist = 0; numlist < n; numlist++)
            {
                
                if (min > numbers[numlist]) min = numbers[numlist]; 
                if (max < numbers[numlist])  max = numbers[numlist]; 
                

            }
            
            
            Console.Title = "console colors";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Het grootste getal is:" + numbers.Max());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Het kleinste getal is:" + numbers.Min());
            Console.ReadKey();

           



        }
    }
}
