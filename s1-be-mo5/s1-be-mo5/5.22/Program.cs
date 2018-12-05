using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 + 1 = 2
            int oud = 1;
            // 1 is het oude getal
            int niew = 2;
            int niewniew = 0;
            int totaal = 0;

                // 2 het niewe getal
                while (oud < 400000)
            {
                niewniew = oud + niew;
                if ((niewniew % 2) == 0)
                {
                    totaal += niewniew;

                }
                oud = niew;
                niew = niewniew;
            }
            int totaal2 = 2 + totaal;
            Console.WriteLine(totaal2);
            Console.ReadLine();
        }
    }
}
