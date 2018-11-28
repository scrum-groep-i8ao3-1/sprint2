using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw datum zo in: DD/MM/YYYY  ");
            string dtm = Console.ReadLine();
            DateTime datum = DateTime.Parse(dtm);
            Console.WriteLine("Deze maand is begonnen op: "+DateTime.Parse(dtm).ToString("dddd")); 
            Console.ReadLine();
        }
    }
}