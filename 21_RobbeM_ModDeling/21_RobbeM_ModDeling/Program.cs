using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_RobbeM_ModDeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // robbe mees
            // 12/11/2026
            // Project ModDeling
            // vleden
            const double _deler = 7;
            const double _deeltal = 27;
            // programma
            Console.WriteLine("Deel 27 / 7");
            Console.WriteLine($"De uitkomst van de deling: {(_deeltal / _deler).ToString()} \n");
            Console.WriteLine($"De uitkomst van de deling: {(Math.Round(_deeltal / _deler,2)).ToString()} \n");
            Console.WriteLine($"7 gaat {(Math.Floor(_deeltal / _deler)).ToString()} in 27");
            Console.WriteLine($"De rest is dan: {(_deeltal % _deler).ToString()}");
        }
    }
}
