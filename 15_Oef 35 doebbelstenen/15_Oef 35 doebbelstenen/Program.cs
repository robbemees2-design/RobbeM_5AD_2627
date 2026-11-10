using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Oef_35_doebbelstenen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // 20/10/2026
            // prject dobbelstenen
            // velden
            int _keuze = 0;
            int _aantalOgen = 0;
           
            do
            {
                // Scherm wissen
                Console.Clear();

                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");

                //    Stap 1a: Toon eerste deel keuzemenu (ogen)
                Console.WriteLine("    1) Geef het aantal ogen van de dobbelsteen in.");

                //    Stap 2: Kijk of het aantal ogen is ingegeven
                //Als ja: 
                if (_aantalOgen != 0)
                {
                    // Stap 3: Toon rest van het keuzemenu(werpen, resetten)
                    Console.WriteLine("    2) Werp de dobbelsteen \n    3) Reset het totaal     4) Aflsuiten");
                }

                // Stap 1b: Toon eerste deel keuzemenu (afsluiten)
                Console.WriteLine("    ");
                try
                {
                    //    Stap 4: Vraag keuze +opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    //Als 1:
                    if(_keuze == 1)
                    {
                        // Stap 5: Vraag hoeveel ogen de dobbelsteen heeft +opslaan
                    }

                    //Als 2: 
                    // Stap 6: Toon de worp van de dobbelsteen +opslaan
                    else if (_keuze == 2)
                    {

                    }

                    //    Stap 7: Toon het totaal van alle worpen tezamen
                    //Als 3:
                    else if (_keuze == 3)
                    {

                    }
                    // Stap 8: reset het resultaat
                    //Als 4:
                    // Stap 9: Toon de afsluittekst
                    //Als niet keuze niet 4
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om naar het hoofdmenu te gaan.");
                    Console.ReadKey();
                }
                //    Stap 10: keer terug naar stap 1

            }
            while (_keuze != 4);

        }

    }
}
