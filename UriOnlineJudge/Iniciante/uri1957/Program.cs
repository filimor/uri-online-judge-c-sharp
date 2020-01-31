using System;

namespace uri1957 // Converter para Hexadecimal
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int v);
            Console.WriteLine(v.ToString("X"));
        }
    }
}
