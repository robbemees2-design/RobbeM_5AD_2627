using System;
using System.Security.Cryptography;

namespace _08_RobbeM_5AD_Rekensom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // 08/10/2026
            // Project Rekensom
            // Velden
            int _EersteGetal = 0;
            int _TweedeGetal = 0;
            int _Uitkomst1 = 0;
            int _Uitkomst2 = 0;
            int _Uitkomst3 = 0;
            int _Uitkomst4 = 0;

            const int _Vermeerdering = 5;
            const int _Vermenigvuldeging = 10;
            const int _Deling = 2;

            // Programma
            try
            {
                //Stap1: vraag eerste getal + opslaan
                Console.WriteLine("Geef hier een getal in en druk daarna op een toets om verder te gaan.");
                _EersteGetal = int.Parse(Console.ReadLine());
                Console.ReadKey();
                // Scherm leegmaken
                Console.Clear();
                try
                {
                    //Stap2: vraag tweede getal + opslaan
                    Console.WriteLine("Geef hier een getal in en druk daarna op een toets om verder te gaan");
                    _TweedeGetal = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                    // Scherm leegmaken
                    Console.Clear();
                    //Stap3: Tel getallen op +opslaan
                    _Uitkomst1 = _EersteGetal + _TweedeGetal;
                    //Stap5: Doe + 5 bij de uitkomst + opslaan
                    _Uitkomst2 = _Uitkomst1 + _Vermeerdering;
                    //Stap6: Vermening vuldig die uitkomst met 10 + opslaan
                    _Uitkomst3 = _Uitkomst2 * _Vermenigvuldeging;
                    //Stap7: Deel resultaat door 2 + opslaan
                    _Uitkomst4 = _Uitkomst3 / _Deling;
                    //Stap7: Toon tresultaat +opslaan
                    Console.WriteLine($"U gaf het getal {_EersteGetal.ToString()} en getal {_TweedeGetal.ToString()} in.");
                    Console.WriteLine($"De som hiervan is {_Uitkomst1.ToString()}.");
                    Console.WriteLine($"Dit getal werd vermeerder met 5.Dit gaf als uitkomst {_Uitkomst2.ToString()}.");
                    Console.WriteLine($"Daarna werd er vermenigvuldig met 10.Dit gaf als uitkomst {_Uitkomst3.ToString()}.");
                    Console.WriteLine($"Als laatste werd er gedeeld door 2.");
                    Console.WriteLine($"De uitijndelijke uitkomst is {_Uitkomst4.ToString()}.");
                    // afsluiten
                    Console.WriteLine("druk op een toets om af te sluiten.");
                    Console.ReadKey();
                }
                catch
                {
                    // Scherm leegmaken
                    Console.Clear();
                    // Foutmelding
                    Console.WriteLine("Uw tweede getal was fout.");
                }

            }
            catch
            {
                // Scherm leegmaken
                Console.Clear();
                // Foutmelding
                Console.WriteLine("Uw eerste getal was fout.");
            }
            

        }
    }
}
