using System;

namespace uri1006 // Média 2
{
    internal static class Program
    {
        private static void Main()
        {
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);
            double.TryParse(Console.ReadLine(), out double c);
            Console.WriteLine($"MEDIA = {(((a * 2) + (b * 3) + (c * 5)) / 10).ToString("F1")}");
        }
    }
}