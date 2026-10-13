using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_RobbeM_16_Project_Kleur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Robbe Mees
            //Project Kleur
            // 13/10/2026
            //Velden
            Byte _keuze =0;


            //Programma
            try
            {
                //Stap1 Toon keuzemenu
                Console.WriteLine("Kies 1 van de onderstaande Kleueren en geef het cijfer ervoor in.");
                Console.WriteLine(" 1) Rood\n 2) Groen\n 3) Blauw");
                _keuze = Byte.Parse(Console.ReadLine());
                Console.WriteLine("Druk op een toets om verder te gaan.");
                Console.ReadKey();
                // Scherm leegmaken
                Console.Clear();
                //Stap2: keuze 1 + oplsaan
                if (_keuze == 1)
                {
                    //Stap3: Maak zin je koos de volgende kleur Rood
                    Console.WriteLine("je koos de volgende kleur Rood.");
                }
                //Stap4: keuze 2 + oplsaan
                else if (_keuze == 2)
                {
                    //Stap5: Maak zin je koos de volgende kleur Groen
                    Console.WriteLine("je koos de volgende kleur Groen.");
                }
                //Stap6: keuze 3 + oplsaan
                else if (_keuze == 3)
                {
                    //Stap7: Maak zin je koos de volgende kleur Blauw
                    Console.WriteLine("je koos de volgende kleur Blauw.");
                }
                else
                {
                    // foutmelding
                    Console.WriteLine("U gaaf geen geldige keuze in.\nDruk op een toets om aftesluiten.");
                    Console.ReadKey();
                }
            }
            catch
            {
                // scherm leegmaken
                Console.Clear();
                // Foutmelding
                Console.WriteLine("Je fag geen juiste waarde in.\nDruk op een toets om verder te gaan.");
                Console.ReadKey();
            }
           

        }
    }
}
