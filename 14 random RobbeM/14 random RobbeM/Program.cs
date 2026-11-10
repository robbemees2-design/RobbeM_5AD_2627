using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_random_RobbeM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Robbe Mees
            //Project 14
            //16/10/2026
            // velden
            Byte _keuze = 0;
            Random _rdm1 = new Random();
            Random _rdm2 = new Random();
            int _getal1 = -1;
            int _getal2 = -1;

            //Programma
            do
            {
                // scherm wissen
                Console.Clear();
                // toon keuze menu
                Console.WriteLine("MAau uw kuize ui onderstaande menu");
                Console.WriteLine("     1) Maak een random aan zonder waarde");
                Console.WriteLine("     2) Maak twee verschillende willikeurige getallen");
                Console.WriteLine("     2) Maak twee verschillende willikeurige getallen met een max waarde");
                Console.WriteLine("     2) Maak twee verschillende willikeurige getallen met een max waarde en min waarde");
                Console.WriteLine("     2) afsluiten");
                try
                {
                    // vraag keuze + opslaan
                    Console.WriteLine("Geef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // als 1
                    if (_keuze == 1)
                    {
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();
                        // toon ze op scherm
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    else if (_keuze == 2)
                    {
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    else if (_keuze == 3)
                    {
                        _getal1 = _rdm1.Next(10);
                        _getal2 = _rdm2.Next(10);
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    else if (_keuze == 4)
                    {
                        _getal1 = _rdm1.Next(10,100);
                        _getal2 = _rdm2.Next(10,100);
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    else if (_keuze == 5)
                    {
                        Console.WriteLine("Daag");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    else
                    {
                        //Scherm leegmaken
                        Console.Clear();
                        //foutmelding
                        Console.WriteLine(" gaf een fout hetal");
                    }

                }
                catch
                {
                    // scherm wissen
                    Console.Clear();
                    Console.WriteLine("U ngaf geen getal in");
                    Console.WriteLine("\nDruk op enter om terug tekeren naar het hoofdmenu.");
                }
            }
            while (_keuze != 5);
        }
    }
}
