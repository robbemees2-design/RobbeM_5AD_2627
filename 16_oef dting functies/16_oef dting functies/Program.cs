using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_oef_dting_functies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Robbe Mees
            //project stringfuncties
            //27/10/2026
            // velden
            Byte _keuze = 0;
            String _zin1 = null;
            String _zin2 = " ";
            // programma
            Console.Clear();
            //Maak een programma dat aan de gebruiker 2 opties geeft.
            //Bij de eerste optie kan hij een woord of zin ingeven en deze moet minimum 5 tekens zijn.
            //Bij optie 2 kan hij een hele reeks bewerkingen op deze zin laten uitvoeren.
            //Er moet bij optie 2 eerst worden nagegaan of er wel een zin is ingegeven.
            Console.WriteLine("Kies een van de onderstaande opties.");
            Console.WriteLine("  1)Geef een woord of zin van minimum 5 tekens.\n  2)Bewerkingen uitvoeren dat je op de zin hebt uitgevoerd\n  3)Afsluiten");
            _keuze = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Druk op een toets om verder te gaan");
            Console.ReadKey();
           
                // vraag zin/woord
                if (_keuze == 1)
                {
                    // scherm leegmaken
                    Console.Clear();
                    //Foutmelding

                    Console.WriteLine("Geef hieronder uw zin of woord van minimum 5 tekens");
                    _zinWoord = Console.ReadLine();
                    if (_zinWoord.Length >= 5)
                    {
                        Console.WriteLine("Je woord/Zin is lang genoeg\nDruk op een toets om verder te gaan");
                        Console.ReadKey();
                    }
                    else
                    {
                        // scherm leegmaken
                        Console.Clear();
                        //Foutmelding
                        Console.WriteLine("Leer tellen!!!\nJE gaf een tekort woord/Zin in");
                        Console.WriteLine("Druk op een toets om verder te gaan.");
                        Console.ReadKey();
                    }
                }
            

            else if(_keuze == 2)
            {
                //Dit zijn de bewerkingen die worden uitgevoerd bij optie 2:

                //Þ Zeg hoeveel tekens het bevat

                //Þ Zet elke letter in een hoofdletter en toon het woord.

                //Þ Zet elke letter in een kleine letter en toon het woord.

                //Þ Wat de eerste 3 tekens zijn(toon deze op het scherm)

                //Þ Wat de laatste 4 tekens zijn(toon deze op het scherm)

                //Þ Zet 5 spaties voor en achter de zin. (toon op het scherm)

                //Þ Verwijder de spaties voor het woord(toon op het scherm)

                //Þ Verwijder de spaties achter het woord(toon op het scherm)

                //Þ Zet 5 spaties voor en achter de zin. (toon op het scherm)

                //Þ Verwijder de spaties voor EN achter het woord in 1 keer(toon op het scherm)

                //Þ Zoek of er een e in het woord of de zin zit

                //a.Als er een e in de zin zit vervang je die door het cijfer 3

                //b.Als er geen e in het woord zit, zeg je “Niet van toepassing”

                //Þ Vraag de gebruiker een 2de zin in te geven.

                //a.Rangschik deze woorden alfabetisch

                //b.Tenzij ze identiek zijn, dan zeg je: “je gaf hetzelfde woord of dezelfde tekst in”
            }
            else if(_keuze == 3)
            {

            }
            else
            {
                // scherm leegmaken
                Console.Clear();
                // foutmelding
                Console.WriteLine("Je gaf een verkeerde keuze in.\nJe kan niet lezen !!!IDIOOT!!!");
                Console.WriteLine("Druk op een toets om verder te gaan");
                Console.ReadKey();
            }
            
        }
    }
}
