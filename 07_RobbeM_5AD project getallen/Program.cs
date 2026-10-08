using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _07_RobbeM_5AD_project_getallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // Project getallen
            // 01/10/2026
            // velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _getal3 = 0;
            // programma
            try
            {
                //Stap1: vraag eerste getal + opslaan
                Console.WriteLine("Geef je eerste getal in.\nEn duw dan op een knop om verder te gaan.");
                _getal1 = int.Parse(Console.ReadLine()); 
                // Scherm leegmaken
                Console.Clear();
                //Stap2: vraag Tweede getal + opslaan
                Console.WriteLine("Geef je tweede getal in.\nEn duw dan op een knop om verder te gaan.");
                _getal2 = int.Parse(Console.ReadLine());
                // Scherm leegmaken
                Console.Clear();
                //Stap3: vraag derde getal + opslaan
                Console.WriteLine("Geef je derde getal in.\nEn duw dan op een knop om verder te gaan.");
                _getal3 = int.Parse(Console.ReadLine());
                // Scherm leegmaken
                Console.Clear();
                //Stap 4: toon de tekst
                Console.WriteLine($"Dit was het derde getal: {_getal3.ToString()}.");
                Console.WriteLine($"Dit was het tweede getal: {_getal2.ToString()}.");
                Console.WriteLine($"Dit was het eerste getal: {_getal1.ToString()}.");
                Console.WriteLine("Druk op en toets om aftesluiten");
                Console.ReadKey();           
            }
            catch
            {
                // scherm leegmaken
                Console.Clear();
                // foutmelding
                Console.WriteLine("Er is iets misgegaan.");
                Console.WriteLine("Druk op een toets om verder te gaan.");
            }
           


        }
    }
}
