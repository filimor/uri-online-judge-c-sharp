using System;

namespace uri1004 // Produto Simples
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int valor1);
            int.TryParse(Console.ReadLine(), out int valor2);
            Console.WriteLine($"PROD = {valor1 * valor2}");
        }
    }
}