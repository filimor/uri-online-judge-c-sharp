using System;

namespace uri1019 // Conversão de Tempo
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine($"{n / 3600}:{n % 3600 / 60}:{n % 3600 % 60}");
        }
    }
}