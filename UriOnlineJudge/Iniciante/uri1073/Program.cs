using System;

namespace uri1073 // Quadrado de Pares
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }
        }
    }
}