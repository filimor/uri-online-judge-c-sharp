using System;

namespace uri1959 // Polígonos Regulares Simples
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            uint.TryParse(entrada[0], out uint n);
            uint.TryParse(entrada[1], out uint l);
            Console.WriteLine(n * l);
        }
    }
}