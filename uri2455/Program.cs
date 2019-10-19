using System;

namespace uri2455
{
    static internal class Gangorra
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int p1);
            int.TryParse(str[1], out int c1);
            int.TryParse(str[2], out int p2);
            int.TryParse(str[3], out int c2);
            Console.WriteLine(p1 * c1 == p2 * c2 ? 0 : p1 * c1 < p2 * c2 ? 1 : -1);
        }
    }
}