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
        }
    }
}
