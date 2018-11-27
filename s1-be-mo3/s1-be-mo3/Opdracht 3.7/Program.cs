using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Schrijf hier je tekst : ");
            string input = Console.ReadLine();
            int val = '*';
            string str = "";
            int len = input.Length;
            char[] ch = input.ToCharArray();
            for (int i = 0; i < len; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' || ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')
                {
                    string v = val.ToString();
                    ch[i] = Convert.ToChar('*');
                    str = str + ch[i];
                    val++;
                }
                else
                    str = str + ch[i];
            }
            Console.WriteLine("Dit is je uitkomst:  " + str);
            Console.ReadLine();
        }
    }
}