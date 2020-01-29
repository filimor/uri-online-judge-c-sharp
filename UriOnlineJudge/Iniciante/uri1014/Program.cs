using System;

namespace uri1014 // Consumo
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int x);
            double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine($"{(x / y).ToString("F3")} km/l");
        }
    }
}