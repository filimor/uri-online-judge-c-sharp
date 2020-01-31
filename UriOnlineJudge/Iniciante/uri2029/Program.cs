using System;

namespace uri2029 // Reservatório de Mel
{
    internal static class Program
    {
        private static void Main()
        {
            const double PI = 3.14;

            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                double.TryParse(str, out double v);
                double.TryParse(Console.ReadLine(), out double d);
                // a = PI * r * r V = a * h
                double area = PI * (d / 2.0) * (d / 2.0);
                double height = v / area;
                Console.WriteLine("ALTURA = " + Math.Round(height, 2).ToString("F2"));
                Console.WriteLine("AREA = " + Math.Round(area, 2).ToString("F2"));
            }
        }
    }
}