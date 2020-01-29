using System;

namespace uri1002 // Área do Círculo
{
    internal static class Program
    {
        private static void Main()
        {
            const double N = 3.14159;
            double.TryParse(Console.ReadLine(), out double raio);
            Console.WriteLine($"A={(N * raio * raio).ToString("F4")}");
        }
    }
}