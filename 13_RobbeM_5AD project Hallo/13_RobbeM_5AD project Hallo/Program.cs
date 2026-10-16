using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RobbeM_5AD_project_Hallo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Robbe Mees
            //Project Hallo
            //16/10/2026
            //Velden
            Byte _keuze = 0;
            String _naam = null;
            //Programma
            // intro
            Console.WriteLine("Welkom op dit programma.\nDruk op een toets om verder te gaan.");
            Console.ReadKey();
            // scherm leegmaken
            Console.Clear();
            do
            {
                // Scherm leegmaken
                Console.Clear();
                //Stap1: toon keuze menu(Toon hallo wereld, Hallo + naam, afskuiten)
                Console.WriteLine("Kies 1 van de onderstaande ofeningen.");
                Console.WriteLine("  1)Toon Hallo Wereld\n  2)Toon Hallo + uw naam\n  3)Afsluiten");
                try
                {
                    // vraag Keuze +  opslaan
                    _keuze = Byte.Parse(Console.ReadLine());
                    Console.WriteLine("Druk op een toets om verder te gaan.");
                    Console.ReadKey();
                    //scherm leegmaken
                    Console.Clear();
                    //Stap 2 toon juiste tekst affhankelijk van keuze
                    //    Als1
                    if (_keuze == 1)
                    {
                        //        Stap3: Toon tekst Hallo Wereld
                        Console.WriteLine("Hallo Wereld.");
                        Console.WriteLine("Druk op een toets om terug tekeren naar het keuzemenu.");
                        Console.ReadKey();
                    }
                    //    Als2               
                    else if (_keuze == 2)
                    {
                        //        Stap4: vraag Voornaam
                        Console.WriteLine("Geef uw naam.");
                        _naam = Console.ReadLine();
                        Console.WriteLine("Druk op een toets om verder te gaan.");
                        Console.ReadKey();
                        // Scherm leegmaken
                        Console.Clear();
                        //Stap5: toon tekst Hallo + naam
                        Console.WriteLine($"Hallo {_naam}.");
                        Console.WriteLine("Druk op een toets om terug tekeren naar het keuzemenu.");
                        Console.ReadKey();
                    }
                    //    Als3: afsluiten
                    else if (_keuze == 3)
                    {
                        Console.WriteLine("Tot Ziens");
                        Console.WriteLine("Druk op een toets om terug tekeren naar het keuzemenu.");
                        Console.ReadKey();
                    }
                    // als niet 3 keer terug naar stap 1
                    else
                    {
                        // foutmeldeing
                        Console.WriteLine("U gaf een fout getal in\n!!!IDIOOT!!!");
                        Console.WriteLine("Druk op een toets om terug tekeren naar het keuzemenu");
                        Console.ReadKey();

                    }          
                }
                catch
                {
                    //scherm leegmaken
                    Console.Clear();
                    //foutemelfing
                    Console.WriteLine("U gaaf een foute waarde in.");
                    Console.WriteLine("Druk op een toets om terug tekeren naar het keuzemenu.");
                    Console.ReadKey();
                }
                
            }
            while (_keuze != 3);

            
            

        }
    }
}
