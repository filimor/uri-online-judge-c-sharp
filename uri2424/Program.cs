using System;

namespace uri2424
{
    internal static class TiraTeima
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int x);
            int.TryParse(entrada[1], out int y);
            Console.WriteLine((x >= 0 && x <= 432 && y >= 0 && y <= 468) ? "dentro" : "fora");
        }
    }
}
