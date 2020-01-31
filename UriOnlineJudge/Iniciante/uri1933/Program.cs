using System;

namespace uri1933 // Tri-du
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            int.TryParse(entrada[1], out int b);
            Console.WriteLine((a >= b) ? a : b);
        }
    }
}