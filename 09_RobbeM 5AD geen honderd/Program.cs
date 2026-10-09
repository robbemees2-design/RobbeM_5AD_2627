using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _09_RobbeM_5AD_geen_honderd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // 09/10/2026
            // project geen 100
            // velden
            int _getal = 0;
            const int _honderd = 100;

            // programma
            try
            {
                // Stap1: vraag positief getal dat geen 100 is +opslaan
                Console.WriteLine("Geef een getal in dat groter of kleiner is dan 100.");
                _getal = int.Parse(Console.ReadLine());
                Console.WriteLine("Druk op een toets om verder te gaan.");
                Console.ReadKey();
                // scherm leegmaken
                Console.Clear();
                // Stap2: controleer of dit klopt
                // Stap3: evalueerµ
                //    Als groter
                if (_getal > _honderd)
                {
                    //        Toon tekst
                    Console.WriteLine($"Het getal is Groter dan {_honderd.ToString()}");
                }
                //    Als kleiner
                else if (_getal <_honderd)
                {
                    //        Toen tekst
                    Console.WriteLine($"Het getal is kleiner dan {_honderd.ToString()}.");
                }
                //    Als gelijk
                else
                {
                    //        Toon tekst
                    Console.WriteLine($"Het getal is {_honderd.ToString()} en dat mag niet.");
                }  
            }
            catch
            {
                // scherm leegmaken
                Console.Clear();
                //Toon foutmelding
                Console.WriteLine("Je gaf een foute waarde in.");
                Console.WriteLine("Druk op een toets om verder te gaan.");
                Console.ReadKey();
                
            }



        }
    }
}
