using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._5
{
    class Program
    {
        static void Main(string[] args)
        {

            //input
            
            Console.Write("Voer uw punten in.");
            int punten = Convert.ToInt32(Console.ReadLine());


            //werking
            if (punten <= 50)
            {
                Console.WriteLine("je beoordeling is een F");
                Console.WriteLine("je hebt een onvoldoende");
                Console.ReadLine();
                
            }
            else if (punten >= 60)
            {
                Console.WriteLine("je beoordeling is een C");
                Console.WriteLine("je hebt een voldoende");
                Console.ReadLine();
                
            }
            else if (punten >= 65)
            {
                Console.WriteLine("je beoordeling is een C+");
                Console.ReadLine();
                
            }
            else if (punten >= 70)
            {
                Console.WriteLine("je beoordeling is een B");
                Console.WriteLine("je hebt een voldoende");
                Console.ReadLine();
                
            }
            else if (punten >= 75)
            {
                Console.WriteLine("je beoordeling is een C+");
                Console.WriteLine("je hebt een voldoende");
                Console.ReadLine();
                
            }
            else if (punten >= 80)
            {
                Console.WriteLine("je beoordeling is een B");
                Console.WriteLine("je hebt een voldoende");
                Console.ReadLine();
                
            }
            else if (punten >= 85)
            {
                Console.WriteLine("je beoordeling is een B+");
                Console.WriteLine("je hebt een voldoende");
                Console.ReadLine();
                
            }
            else if (punten >= 90)
            {
                Console.WriteLine("je beoordeling is een A");
                Console.WriteLine("je hebt een voldoende");
                Console.ReadLine();
                
            }
            else if (punten >= 95)
            {
                Console.WriteLine("je beoordeling is een A+");
                Console.WriteLine("je hebt een voldoende");
                Console.ReadLine();
                
            }
            Console.ReadKey();
            Console.WriteLine();
            

            

            



        }
    }
}
