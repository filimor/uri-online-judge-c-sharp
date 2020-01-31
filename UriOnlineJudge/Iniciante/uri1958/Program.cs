// Não passa em todos os casos de teste
// Wrong answer (5%)

using System;
using System.Globalization;

namespace uri1958 // Notação Científica
{
    internal static class Program
    {
        private static void Main()
        {
            double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double x);
            if (x >= 0.0000E+00)
            {
                Console.Write("+");
            }
            //if (x == 0 && Math.Sign(x) == -1) Console.WriteLine("-");
            Console.WriteLine(x.ToString("0.0000E+00", CultureInfo.InvariantCulture));
        }
    }
}