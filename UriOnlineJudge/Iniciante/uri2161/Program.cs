using System;

namespace uri2161 // Raiz Quadrada de 10
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            double sqrt10 = 0;
            for (int i = 0; i < n; i++)
            {
                sqrt10 += 6.0;
                sqrt10 = 1.0 / sqrt10;
            }
            sqrt10 += 3.0;
            Console.WriteLine(sqrt10.ToString("F10"));
        }
    }
}