using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_RobbeM_toonDatum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // 12/11/2026
            // project Toon datum
            // velden
            DateTime _datum = default(DateTime);
            DateTime _datum2 = DateTime.MinValue;
            DateTime _datum3 = DateTime.MaxValue;
            bool _herhalen = true;
            // programma
            while(_herhalen)
            {
                Console.Clear();
                Console.WriteLine($"De default DateTime: {_datum.ToString()}.");
                Console.WriteLine($"Het minimum DateTime: {_datum2.ToString()}.");
                Console.WriteLine($"De huidige DateTime: {DateTime.Now.ToString()}");
                Thread.Sleep(1000);
            }
            
        }
    }
}
