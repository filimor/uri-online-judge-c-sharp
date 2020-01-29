using System;

namespace uri1003 // Soma Simples
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine($"SOMA = {a + b}");
        }
    }
}