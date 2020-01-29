using System;

namespace uri1011 // Esfera
{
    internal static class Program
    {
        private static void Main()
        {
            const double PI = 3.14159;
            double.TryParse(Console.ReadLine(), out double raio);
            Console.WriteLine($"VOLUME = {(4.0 / 3.0 * PI * raio * raio * raio).ToString("F3")}");
        }
    }
}