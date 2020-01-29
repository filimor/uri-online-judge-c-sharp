using System;

namespace uri1144 // Sequência Lógica
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
                Console.WriteLine($"{i} {(i * i) + 1} {(i * i * i) + 1}");
            }
        }
    }
}