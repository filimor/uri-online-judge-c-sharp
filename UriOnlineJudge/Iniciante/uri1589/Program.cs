using System;

namespace uri1589 // Bob Conduite
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int r1);
                int.TryParse(entrada[1], out int r2);
                Console.WriteLine(r1 + r2);
            }
        }
    }
}