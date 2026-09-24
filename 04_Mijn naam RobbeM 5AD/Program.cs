using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Mijn_naam_RobbeM_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // Project Hallo naam
            // 22/09/2026

            // velden
            String _naamGebreuker = null;
            String _bewerking = null;

            // Programma
            //Stap 1: vraag naam
            Console.WriteLine("Geef hier uw naam in en druk daarna op enter.");
            _naamGebreuker = Console.ReadLine();
            // scherm leegmaken
            Console.Clear();
            //Stap2: Maak de juiste zin
            _bewerking = $"Hallo {_naamGebreuker}\nMijn naam is Robbe en ik ben de programmeur ";
            // scherm leegmaken
            Console.Clear();
            //Stap 3: toon zin = Mijn naam is < jouw naam > en ik ben de programmeur.
            // Console.WriteLine($"Mijn naam is {_naamGebreuker} en ik ben de programmeur.");
            Console.WriteLine(_bewerking);

        }
    }
}
