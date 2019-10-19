using System;

namespace uri2454
{
    internal static class Fliper
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int p);
            int.TryParse(str[1], out int r);
            Console.WriteLine(p == 0 ? 'C' : r == 0 ? 'B' : 'A');
        }
    }
}