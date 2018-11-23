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
        { Console.Write("datum van de mans ze geboorte dd/mm/yy : ");
            string me = Console.ReadLine();
            Console.Write("datum van de vrouw ze geboorte dd/mm/yy : ");
            string xe = Console.ReadLine();
            DateTime myBirthdatee = DateTime.Parse(me);
            TimeSpan myAGEE = DateTime.Now.Subtract(myBirthdatee);
            double mee = Convert.ToDouble(myAGEE.TotalHours.ToString());
            Double meee = mee / 24;
            Double meeee = meee / 365;
            double man = Math.Truncate(meeee);
            DateTime myBirthdate = DateTime.Parse(xe);
            TimeSpan myAGE = DateTime.Now.Subtract(myBirthdate);
            Double xee = Convert.ToDouble(myAGE.TotalHours.ToString());
            Double xeee = xee / 24;
            Double xeeee = xeee / 365;
            double vrouw = Math.Truncate(meeee);
            int antwoord1 = (int)Math.Round(vrouw - man);
            int antwoord2 = (int)Math.Round(man - vrouw);
            if (antwoord1 < 0)
            {
                double antwoord = antwoord2;
                Console.WriteLine(antwoord);
                Console.ReadLine();
            }
            if (antwoord2 < 0) 
            {
                int antwoord = antwoord2 = antwoord1;
                Console.WriteLine(antwoord);
                Console.ReadLine();
            }
            else
            {
                int antwoord = (int)Math.Round(man - vrouw );
                Console.Write(antwoord);
                Console.ReadKey();
            }
        }
    }
}
