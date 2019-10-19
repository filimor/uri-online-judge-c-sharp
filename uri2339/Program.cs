using System;

namespace uri2339
{
    internal static class AvioesdePapel
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int c);
            int.TryParse(str[1], out int p);
            int.TryParse(str[2], out int f);
            Console.WriteLine(f <= p / c ? "S" : "N");
        }
    }
}