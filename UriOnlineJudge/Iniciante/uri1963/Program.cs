using System;

namespace uri1963 // O Filme
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double.TryParse(entrada[0], out double a);
            double.TryParse(entrada[1], out double b);
            Console.WriteLine(Math.Abs((1.0 - (b / a)) * 100.0).ToString("F2") + "%");
        }
    }
}