using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_delen_getalen_RobbeM_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Robbe Mees
            // 10/11/2026
            // Delen Getallen

            // Velden
            int intDeler = 5;
            int intdeeltal = 3;
            double doubleDeler = 5;
            double doubleDeeltal = 5;
            Decimal decimalDeler = 5m;
            Decimal decimalDeeltal = 5m;
            // programa
            Console.WriteLine("normale deling met / :");
            Console.WriteLine($"met int deler en deeltal {(intdeeltal/intDeler).ToString()}");
            Console.WriteLine($"met int deler en double deeltal {(doubleDeeltal/intDeler).ToString()}");
            Console.WriteLine($"met int deler en double deeltal {(decimalDeeltal/intDeler).ToString()}");
            Console.WriteLine();
            Console.WriteLine($"met int double deler en double deeltal {(intdeeltal / doubleDeler).ToString()}");
            Console.WriteLine($"met int double deler en double deeltal {(doubleDeeltal / doubleDeler).ToString()}");
            //Console.WriteLine($"met int double deler en double deeltal {(decimalDeeltal / doubleDeler).ToString()}");
            Console.WriteLine();
            Console.WriteLine($"met int double deler en double deeltal {(intdeeltal / decimalDeler).ToString()}");
            //Console.WriteLine($"met int double deler en double deeltal {(doubleDeeltal / decimalDeler).ToString()}");
            Console.WriteLine($"met int double deler en double deeltal {(decimalDeeltal / decimalDeeltal).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"Met getal als deler en double deeltal {(intdeeltal / 7).ToString()}");
            Console.WriteLine($"Met getal als deler en double deeltal {(decimalDeeltal / 7).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"Met getal als deler en getal deeltal 3 {(3 / intDeler).ToString()}");
            Console.WriteLine($"Met getal als deler en en getal 3 {(3 / doubleDeler).ToString()}");
        }
    }
}
