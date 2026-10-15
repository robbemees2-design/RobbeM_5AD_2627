using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_RobbeM_5AD_Project_keuze_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Robbe Mees
            //Project keuzemenu
            //13/10/2026
            //Velden
            Byte _keuze = 0;
            //Programma
            //intro 
            Console.WriteLine("Welkom op dit programma.\nDruk op een toets om verder te gaan.");
            Console.ReadKey();
            // Scherm leegmaken
            Console.Clear();
            do
            {     
                //Stap1: toon keuze menu
                Console.WriteLine("Kies 1 van de onderstaande keuzes.");
                try
                {              
                    //Stap 2 vraag de keuze + opslaan
                    Console.WriteLine(" 1) Keuze1\n 2) Keuze2\n 3) Keuze3\n 4) Afsluiten");
                    _keuze = Byte.Parse(Console.ReadLine());
                    Console.WriteLine("Druk op een toets om verder te gaan");
                    Console.ReadKey();
                    // scherm leegmaken
                    Console.Clear();
                    //Stap3: toon de juiste tekst afhankelijk van de keuze
                    // als 1
                    if (_keuze == 1)
                    {
                        Console.WriteLine($"U koos keuze {_keuze.ToString()}");
                        Console.WriteLine("Druk op een toets om verder te gaan");
                        Console.ReadKey();
                        // scherm leegmaken
                        Console.Clear();
                    }
                    // als 2
                    else if (_keuze == 2)
                    {
                        Console.WriteLine($"U koos keuze {_keuze.ToString()}");
                        Console.WriteLine("Druk op een toets om verder te gaan");
                        Console.ReadKey();
                        // scherm leegmaken
                        Console.Clear();
                    }
                    // als 3
                    else if (_keuze == 3)
                    {
                        Console.WriteLine($"U koos keuze {_keuze.ToString()}");
                        Console.WriteLine("Druk op een toets om verder te gaan");
                        Console.ReadKey();
                        // scherm leegmaken
                        Console.Clear();
                    }
                    // als 4
                    else if(_keuze == 4)
                    {
                        Console.WriteLine("Tot de volgende keer.");
                    }
                    // als iets anders is
                    else
                    {
                        Console.WriteLine("U gaf een getal in dat groter is dan 4.\nU BENT EEN IDIOOT!!!");
                        Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                        // scherm leegmaken
                        Console.Clear();

                    }
                }
                catch
                {
                    // scherm leegmaken
                    Console.Clear();
                    // foutmelding
                    Console.WriteLine("je gaf geen getal.\nDruk om terug tekeren naar het keuzemenu.");
                    Console.ReadKey();
                    // Scherm leegmaken
                    Console.Clear();

                }
                //Stap 4 als keuze niet 4 keer dan terug naar het keuzemenu
            } while (_keuze != 4);         
        }
    }
}
