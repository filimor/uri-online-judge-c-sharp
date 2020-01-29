using System;

namespace uri1007 // Diferença
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            int.TryParse(Console.ReadLine(), out int c);
            int.TryParse(Console.ReadLine(), out int d);
            Console.WriteLine($"DIFERENCA = {(a * b) - (c * d)}");
        }
    }
}