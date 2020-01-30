using System;

namespace uri1177 // Preenchimento de Vetor II
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            int[] n = new int[1000];

            for (int i = 0; i < 1000;)
            {
                for (int j = 0; j < t && i < 1000; j++, i++)
                {
                    n[i] = j;
                    Console.WriteLine($"N[{i}] = {n[i]}");
                }
            }
        }
    }
}