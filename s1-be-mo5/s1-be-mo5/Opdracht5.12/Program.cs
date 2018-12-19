﻿using System;
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
            //bepaald de grote van de array dus als je 5 aangeeft zal get max een index hebben van 5
            Console.Write("Hoeveel nummers moet de lijst bevatten?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            // bepaald de naam van de array dus in dit geval is het n
            int[] numbers = new int[n];
            //zet min en max op 0
            int min = numbers[0];
            int max = numbers[0];
            int hoog = 0;



            // voegt nummers toe tot bepaalde max van de array is bereikt
            for (int numlist = 0; numlist < n; numlist++)
            {
                Console.Write("Voer nummer {0} in:  ", numlist + 1);
                numbers[numlist] = Convert.ToInt32(Console.ReadLine());
                // Bepaald de max en min van de array
               
                for (int i = 0; i < 10; i++ )
                {
                    if (numbers[numlist] == max)
                    {
                        hoog = numbers[numlist];
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(max);
                        Console.ResetColor();
                    }
                    else if (numbers[numlist] == min)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(min);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(numbers[numlist]);
                    }
                }
                Console.Clear();

                
            }
            
            // geeft de lijst met ingevoerde waardes weer 
           for (int i = 0; i < numbers.Count(); i++)
            {
                if (i == numbers.Max())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(numbers[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == numbers.Min())
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(numbers[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }




            }
               
            //Laat het grootste en kleinste getal zien 
            Console.Write("Het grootste getal is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(numbers.Max() + "\n"); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Het kleinste getal is: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(numbers.Min());
            
          
          


            Console.ReadKey();
          
        }
    }
}
