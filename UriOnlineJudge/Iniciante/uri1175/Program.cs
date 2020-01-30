using System;

namespace uri1175 // Troca em Vetor I
{
    internal static class Program
    {
        private static void Main()
        {
            int[] n = new int[20];
            int t;
            for (int i = 0; i < n.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out n[i]);
            }
            for (int j = 0; j < (n.Length / 2); j++)
            {
                t = n[j];
                n[j] = n[n.Length - j - 1];
                n[n.Length - j - 1] = t;
            }
            for (int k = 0; k < n.Length; k++)
            {
                Console.WriteLine($"N[{k}] = {n[k]}");
            }
        }
    }
}