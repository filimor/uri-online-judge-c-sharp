using System;

namespace uri2373
{
    internal static class Garcom
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int l);
                int.TryParse(str[1], out int c);
                if (l > c)
                {
                    total += c;
                }
            }

            Console.WriteLine(total);
        }
    }
}