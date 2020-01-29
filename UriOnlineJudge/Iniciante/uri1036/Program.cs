using System;

namespace uri1036 // Fórmula de Bhaskara
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double.TryParse(entrada[0], out double a);
            double.TryParse(entrada[1], out double b);
            double.TryParse(entrada[2], out double c);
            double delta = (b * b) - (4.0 * a * c);
            if (delta < 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine($"R1 = {((-b + Math.Sqrt(delta)) / (2.0 * a)).ToString("F5")}");
                Console.WriteLine($"R2 = {((-b - Math.Sqrt(delta)) / (2.0 * a)).ToString("F5")}");
            }
        }
    }
}