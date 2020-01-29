using System;

namespace uri1005 // Média 1
{
    internal static class Program
    {
        private static void Main()
        {
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine($"MEDIA = {(((3.5 * a) + (7.5 * b)) / 11).ToString("F5")}");
        }
    }
}