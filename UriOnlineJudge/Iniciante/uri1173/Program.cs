using System;

namespace uri1173 // Preenchimento de Vetor I
{
    internal static class Program
    {
        private static void Main()
        {
            int[] n = new int[10];
            int.TryParse(Console.ReadLine(), out n[0]);
            Console.WriteLine($"N[0] = {n[0]}");
            for (int i = 1; i < 10; i++)
            {
                n[i] = 2 * n[i - 1];
                Console.WriteLine($"N[{i}] = {n[i]}");
            }
        }
    }
}