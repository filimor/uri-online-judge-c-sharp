using System;

namespace uri1043 // Triângulo
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double.TryParse(entrada[0], out double a);
            double.TryParse(entrada[1], out double b);
            double.TryParse(entrada[2], out double c);
            if ((a > Math.Abs(b - c)) && (b > Math.Abs(a - c)) && (c > Math.Abs(a - b)) &&
                (a < (b + c)) && (b < (a + c)) && (c < (a + b)))
            {
                Console.WriteLine($"Perimetro = {(a + b + c).ToString("F1")}");
            }
            else
            {
                Console.WriteLine($"Area = {((a + b) * c / 2.0).ToString("F1")}");
            }
        }
    }
}