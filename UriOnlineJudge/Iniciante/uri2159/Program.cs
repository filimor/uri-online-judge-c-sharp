using System;

namespace uri2159 // Número Aproximado de Primos
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            double p = n / Math.Log(n);
            Console.WriteLine($"{p:F1} {1.25506 * p:F1}");
        }
    }
}