using System;

namespace uri1172 // Substituição em Vetor I
{
    internal static class Program
    {
        private static void Main()
        {
            int[] x = new int[10];
            for (int i = 0; i < x.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out x[i]);
                if (x[i] <= 0)
                {
                    x[i] = 1;
                }
            }
            for (int j = 0; j < x.Length; j++)
            {
                Console.WriteLine($"X[{j}] = {x[j]}");
            }
        }
    }
}