using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _26_RobbeM_Raadspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees$
            // 13/11/2026
            // project gokspel
            // velden
            Byte _keuze = 0;
            const Byte _aantalKansen = 7;
            // programma
            do
            {
                // sherm wissen
                Console.Clear();
                // Stap 1: toon het menu(Spel spelen, afsluiten)
                Console.WriteLine("Maak uw keuze");
                Console.WriteLine("  1) Spel spelen\n  2) afsluiten");

                try
                {
                    // Stap 2: vraag keuze +opslaan
                    Console.WriteLine("\nGeef uw keuze");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Stap3: Als1:
                    // sherm wissen
                    Console.Clear();
                    if (_keuze == 1)
                    {
                        //            Stap 4: maak een willikeurig getal
                        Random rdm = new Random();
                        Byte geheimgetal = Convert.ToByte(rdm.Next(1, 101));
                        bool gevonden = false;
                        //        Stap5: geef de gebruiker 5 kansen
                        for(int i = _aantalKansen; i> 0; i--)
                        {
                            try
                            {
                                
                                //        Stap6: vraag de gokpging van de gebruiker
                                Console.WriteLine($"U heeft nog {i.ToString()} kansen");
                                Byte raadkans = Byte.Parse(Console.ReadLine());
                                // scherm wissen
                                Console.Clear();

                                //Stap7: kijk of de gok juist is
                               
                                //            Als de gok kleiner is:
                                if (raadkans < geheimgetal)
                                {
                                    //				Stap8: zeg dat het geraden getal hoger is
                                    Console.WriteLine("Sorry, maar het geraden getal is hoger");
                                    Console.WriteLine("\nDruk op enter om");
                                }
                                //            Als de gok hoger is:
                                else if (raadkans > geheimgetal)
                                {
                                    //				Stap9: zeg het geraden getal is lager
                                    Console.WriteLine("Sorry, maar het geraden getal is Lager");
                                    Console.WriteLine("\nDruk op enter om");
                                }
                                //            Als de gok juist is:
                                else
                                {
                                    //				Stap 10: zeg proficiat + stop lus
                                    Console.WriteLine($"Feest! yeeee! Je hebt het getal geraden in {(_aantalKansen + 1 - i).ToString()}");
                                    Console.WriteLine("\nGa asjeblieft iets nuttig doen met uw leven");
                                    gevonden = true;
                                }
                                // ga na of het gevonden is
                                if (gevonden)
                                {
                                    i = 1;
                                    Console.WriteLine("\nDruk op enter om terug tekeren naar het menu");
                                    // stop lussen
                                    break;
                                }
                                else
                                {
                                    if(i == 1)
                                    {
                                        //            Als de kansen op zijn
                                        //                Stap 11: Zeg de kansen zijn op en toon het getal
                                        Console.WriteLine("Jammer maar jouw kansen zijn op en je hebt hetal niet gevonden");
                                        Console.WriteLine($"Hte getal dat je zocht was: {geheimgetal.ToString()}");
                                        Console.WriteLine("\nDruk op enter om terug tekeren naar het menu");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Druk op enter om opnieuw te spelen");
                                    }
                                }
                                Console.ReadKey();

                            }
                            catch
                            {
                                // sherm wissen
                                Console.Clear();

                                // foutmelding
                                Console.WriteLine("U gaf geen getal in\n Fruk op een toets om verder te gaan");
                                Console.ReadKey();

                                // zorg dat het aaantal kansen behouden blijft
                                i++;

                            }
                           
                        }                        
                        //    Als de gok niet juist was en er nog raad kansen zijn keer terug naar stap 5
                    }
                    else if(_keuze ==2)
                    {
                        // Als2:
                        //        Stap12: Toon afsluiten
                        Console.WriteLine("Druk op enter om aftesluiten\n Fruk op een toets om verder te gaan");
                        Console.ReadKey();
                    }

                    // in elk ander geval
                    else
                    {
                        // foutmelding
                        Console.WriteLine("U gaf geen getal in\n Fruk op een toets om verder te gaan");
                        Console.ReadKey();
                    }
                    //Scherm wissen
                    Console.Clear();
                    
                }
                catch
                {
                    // scherm wissen
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in\n Fruk op een toets om verder te gaan");
                    Console.ReadKey();
                }
                // Stap13: als de keuze niet2 is keer terug naar stap 2

            }
            while (_keuze != 2);



        }
    }
}
