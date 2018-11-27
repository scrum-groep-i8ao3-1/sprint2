using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
            //vragen
        { Console.Write("datum van de mans ze geboorte dd/mm/yy : ");
            string me = Console.ReadLine();
            Console.Write("datum van de vrouw ze geboorte dd/mm/yy : ");
            string xe = Console.ReadLine();
            //vragen
            //man
            //mijn verjaardag is (input) afgerond
            DateTime myBirthdatee = DateTime.Parse(me);
            // mijn leeftijd is huidige datum - mijn geboorte datum
            TimeSpan myAGEE = DateTime.Now.Subtract(myBirthdatee);
            // converter
            double mee = Convert.ToDouble(myAGEE.TotalHours.ToString());
            Double dag1 = mee / 24;
            double man = Math.Truncate(dag1);
            //man
            //vrouw
            DateTime myBirthdate = DateTime.Parse(xe);
            TimeSpan myAGE = DateTime.Now.Subtract(myBirthdate);
            Double xee = Convert.ToDouble(myAGE.TotalHours.ToString());
            Double dag2 = xee / 24;
            double vrouw = Math.Truncate(dag2);
            //vrouw
            //berekeningen
            int antwoord1 = (int)Math.Round(vrouw - man);
            int antwoord2 = (int)Math.Round(man - vrouw);
            if (antwoord1 < 0)
            {
                Console.Write(antwoord2);
                Console.ReadKey();
                double antwoord = antwoord2;
                Console.WriteLine(antwoord);
                Console.ReadLine();
                Console.Write("a1");
                Console.ReadKey();
            }
            if (antwoord2 < 0) 
            {
                Console.Write(antwoord1);
                Console.ReadKey();
                int antwoord  = antwoord1;
                Console.WriteLine(antwoord);
                Console.ReadLine();
                Console.Write("a2");
                Console.ReadKey();
            }
            else
            {
                int antwoord = (int)Math.Round(man - vrouw );
                Console.Write(antwoord);
                Console.ReadKey();
                Console.Write("else");
                Console.ReadKey();
            }
        }
    }
}
