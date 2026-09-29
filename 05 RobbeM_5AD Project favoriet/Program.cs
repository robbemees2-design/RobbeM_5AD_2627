using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_RobbeM_5AD_Project_favoriet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // project favoriet
            // 29/09/2026
            // velden
            String _kleur = null;
            String _dag = null;
            String _seizoen = null;

            // programma
            //Stap 1 vraag een kleur + opslaan
            Console.WriteLine("Kies je favoriete kleur.");
            _kleur = Console.ReadLine();    
            //Stap 2 maak zin = Je koos
            Console.WriteLine($"je favoriete kleur is {_kleur}.");
            Console.WriteLine("Druk op een toets om verder te gaan");
            Console.ReadKey();
            // Scherm leegmaken
            Console.Clear();
            
            //Stap 3 vraag favorite dag
            Console.WriteLine("Wat is je favoriete dag van de week?");
            _dag = Console.ReadLine();
            //stap 4 maak zin = Je favoriete dag is
            Console.WriteLine($"je favoriete dag is {_dag}.");
            Console.WriteLine("Druk op een toets om verder te gaan");
            Console.ReadKey();
            // Scherm leegmaken
            Console.Clear();

            //stap 5 vraag favoriete seizoon
            Console.WriteLine("Kies je favoriete seizoen.");
            _seizoen = Console.ReadLine();
            //stap 6 maak zin = Je favoriete seizoen is ….
            Console.WriteLine($"je favoriete seizoen is {_seizoen}.");
            Console.WriteLine("Druk op een toets om het programma af te sluiten");
            Console.ReadKey();

        }
    }
}
