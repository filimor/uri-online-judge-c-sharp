using System;

namespace uri1044 // Múltiplos
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            int.TryParse(entrada[1], out int b);
            Console.WriteLine(((b % a) == 0) || ((a % b) == 0) ? "Sao Multiplos" : "Nao sao Multiplos");
        }
    }
}