using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RobbeM_5AD_Foutmelding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // Project Foutmelding
            // 01/10/2026
            // velden
            int _getal = 0;
            // programma 
            try
            {
                // Stap 1: vraag getal +opslaan
                Console.WriteLine("geef een natuurlijk getal in.");
                int.Parse(Console.ReadLine());
            }
            catch
            {
                // scherm leegmaken
                Console.Clear();
                // foutmelding
                Console.WriteLine("Uw moet een hetal in geven geen tekst.");
            }
            



        }
    }
}
