using System;

namespace uri2166 // Raiz Quadrada de 2
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            double sqrt2 = 0;
            for (int i = 0; i < n; i++)
            {
                sqrt2 += 2;
                sqrt2 = 1 / sqrt2;
            }
            sqrt2++;
            Console.WriteLine(sqrt2.ToString("F10"));
        }
    }
}