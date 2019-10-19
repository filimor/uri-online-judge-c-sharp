using System;

namespace uri2232
{
    internal static class TriangulodePascal
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                double soma = 0;
                int.TryParse(Console.ReadLine(), out int n);
                for (int j = 0; j < n; j++)
                {
                    soma += Math.Pow(2, j);
                }
                Console.WriteLine(soma);
            }
        }
    }
}