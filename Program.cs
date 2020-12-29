using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus5_Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonus 5 - Uso de constantes");
            Console.WriteLine("");
            Console.WriteLine("double remera = 59.9, pantalon = 99.9, campera = 149.9;");
            Console.WriteLine("const double IVA = 21;");
            double remera = 59.9, pantalon = 99.9, campera = 149.9;
            const double IVA = 21;

            Console.WriteLine("precio final remera: " + (remera + remera * IVA / 100));
            Console.WriteLine("precio final pantalon: " + (pantalon + pantalon * IVA / 100));
            Console.WriteLine("precio final remera: " + (campera + campera * IVA / 100));

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

        }
    }
}
