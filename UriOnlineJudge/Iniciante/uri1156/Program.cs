using System;

namespace uri1156 // Sequência S II
{
    internal static class Program
    {
        private static void Main()
        {
            double s = 0;
            for (double i = 1, j = 1; i <= 39; i += 2, j *= 2)
            {
                s += i / j;
            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}