using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Opdracht_4._8
{
    public class CultureInfo
    {
        class Program
        {
            static void Main(string[] args)
            {
                DateTime testdatum = DateTime.Now;
                //DateTime testdatum = new DateTime(2018, 6, 12);
                Console.WriteLine("Kies een taal u heeft de keuze uit: Nederlands, Duits, Engels, Frans, Spaans en Italiaans");
                string taal = Console.ReadLine();

                if (taal == "Nederlands")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("nl-NL");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("De huidige maand: " + maand);
                    Console.ReadLine();
                }

                if (taal == "Duits")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("de-DE");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("Der aktuelle Monat ist: " + maand);
                    Console.ReadLine();
                }

                if (taal == "Engels")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-GB");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("The current month is: " + maand);
                    Console.ReadLine();
                }

                if (taal == "Frans")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("fr-FR");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("Le mois en cours est: " + maand);
                    Console.ReadLine();
                }

                if (taal == "Spaans")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("es-ES");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("El mes actual es: " + maand);
                    Console.ReadLine();
                }

                if (taal == "Italiaans")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("it-IT");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("Il mese corrente è: " + maand);
                    Console.ReadLine();
                }

                Console.WriteLine("Wilt u een andere taal kiezen? type ja of nee");
                string antwoord = Console.ReadLine();

                if (antwoord == "ja") 
                Console.WriteLine("Kies een taal u heeft de keuze uit: Nederlands, Duits, Engels, Frans, Spaans en Italiaans");
                string taal2 = Console.ReadLine();

                if (taal2 == "Nederlands")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("nl-NL");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("De huidige maand: " + maand);
                    Console.ReadLine();
                }

                if (taal2 == "Duits")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("de-DE");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("Der aktuelle Monat ist: " + maand);
                    Console.ReadLine();
                }

                if (taal2 == "Engels")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-GB");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("The current month is: " + maand);
                    Console.ReadLine();
                }

                if (taal2 == "Frans")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("fr-FR");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("Le mois en cours est: " + maand);
                    Console.ReadLine();
                }

                if (taal2 == "Spaans")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("es-ES");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("El mes actual es: " + maand);
                    Console.ReadLine();
                }

                if (taal2 == "Italiaans")
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("it-IT");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    string maand = testdatum.ToString("MMMM");
                    Console.WriteLine("Il mese corrente è: " + maand);
                    Console.ReadLine();
                }
            }
        }
    }
}
