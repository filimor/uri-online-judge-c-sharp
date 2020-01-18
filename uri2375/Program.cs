using System;

namespace uri2375
{
    internal static class Sedex
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            int.TryParse(entrada[1], out int l);
            int.TryParse(entrada[2], out int p);
            Console.WriteLine((n <= a && n <= l && n <= p) ? "S" : "N");
        }
    }
}
