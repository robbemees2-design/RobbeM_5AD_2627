using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _24_RobbeM_dateTimeFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // 12/11/2026
            // project Toon datum
            // velden
            DateTime _datum = DateTime.MinValue;
            // programma
            _datum = DateTime.Now;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");
            // neem enkel de datum en niet de tijd
            _datum = DateTime.Today;
            Console.WriteLine($" De datum en tijd van vandaag: {_datum.ToString()}\n");
            _datum = DateTime.Now.Date;
            Console.WriteLine($" De datum en tijd van vandaag: {_datum.Date.ToString()}\n");
            // jaar van de huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($" het jaar van vandaag: {_datum.Year.ToString()}\n");
            // dag huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($" De dag van vandaag: {_datum.Day.ToString()}\n");
            // uur van huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($" het uur van vandaag: {_datum.Hour.ToString()}\n");
            // Dag van de week
            Console.WriteLine($"Het uur van vandaag: {_datum.DayOfWeek.ToString()}\n");
            int uitkomst = Convert.ToInt32(_datum.DayOfWeek);
            Console.WriteLine(uitkomst.ToString());

            // Toevoegen van jaren, maanden, dagen, uren, minuten, seconden ...
            _datum = _datum.AddYears(1).AddDays(4).AddHours(2);
            Console.WriteLine($"Het uur van vandaag: {_datum.ToString()}\n");
            _datum = _datum.AddYears(-1).AddDays(-4).AddHours(-2);
            Console.WriteLine($"Het uur van vandaag: {_datum.ToString()}\n");

            // De verschillende ToStrings mogelijkheden
            Console.WriteLine("Hier zijn de verschillende tostring opties:");
            Console.WriteLine($"De normale ToString: {_datum.ToString()}\n");
            Console.WriteLine($"De Long Date: {_datum.ToLongDateString()}\n");
            Console.WriteLine($"De Long Time: {_datum.ToLongTimeString()}\n");
            Console.WriteLine($"De Short Date: {_datum.ToShortDateString()}\n");
            Console.WriteLine($"De Short Time: {_datum.ToShortTimeString()}\n");
            // Rekenen met datums
            DateTime datum2 = DateTime.Now.AddYears(3);
            // Rechtstreeks rekenen met datums gaat niet!!
            //_datum = datum2 - _datum;
            // Je moet variabelen gebruiken van de datatype TimeSpan.
            TimeSpan verschil = datum2 - _datum;
            Console.WriteLine($"{verschil.ToString()}\n");
            double aantalDagen = verschil.Days;
            double aantalDagen2 = verschil.TotalDays;
            Console.WriteLine($"Days = {aantalDagen} en totaldays = {aantalDagen2}\n");

            double aantalUren = verschil.Hours;
            double aantalUren2 = verschil.TotalHours;
            Console.WriteLine($"Days = {aantalUren} en totaldays = {aantalUren2}\n");

            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();

            //scherm leegmaken
            Console.Clear();
            // laat de gebruiker de datum ingeven
            Console.WriteLine("\n Geef een  datum in (dd/mm/jjjj)");
            String datum = Console.ReadLine();

            //laat de gebruiker een uur ingeven
            Console.WriteLine("\n Geef een bepaald tijdstip van deze dag(hh:mm)");
            String tijdstip = Console.ReadLine();

            try
            {
                DateTime ingegevenDatum = DateTime.Parse($"{datum} {tijdstip}");
                DateTime enkelDatum = DateTime.Parse($"{datum}");
                DateTime enkelUur = DateTime.Parse($"{tijdstip}");

                Console.WriteLine($"Hier is de volledige datum en tijd {ingegevenDatum.ToString()}");
                Console.WriteLine($"Hier is enkel de datum {enkelDatum.ToString()}");
                Console.WriteLine($"Hier is enkel de tijd{enkelUur.ToString()}");

                //bevesteging
                Console.WriteLine("Gelukt");
                Console.WriteLine("\nDruk op enter om verder te gaan");
                Console.ReadLine();

                //scherm leegmaken
                Console.Clear();

                // zeg of de ingegeven datum vroeger of later is dan vandaag
                if(_datum.Date < ingegevenDatum.Date)
                {
                    Console.WriteLine("jou ingegeven datum ligt in de toekomst");
                }
                else if (_datum.Date > ingegevenDatum.Date)
                {
                    Console.WriteLine("jou ingegeven datum ligt in het verleden");
                }
                else
                {
                    Console.WriteLine("jou ingegeven datum is de dag van vandaag");
                }
                Console.WriteLine("\nDruk op enter om verder te gaan");
                Console.ReadLine();

            }
            catch
            {
                //foutmelding
                Console.WriteLine("Er ging iets fout");
                Console.WriteLine("\nDruk op enter om verder te gaan");
                Console.ReadLine();
            }
        }
    }
}
