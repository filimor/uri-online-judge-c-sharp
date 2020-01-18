using System;

namespace uri2786
{
    internal static class PisoDaEscola
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int l);
            int.TryParse(Console.ReadLine(), out int c);
            Console.WriteLine((l * c) + ((l - 1) * (c - 1)));
            Console.WriteLine(((l - 1) * 2) + ((c - 1) * 2));
        }
    }
}
