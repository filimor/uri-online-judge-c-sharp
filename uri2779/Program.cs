using System;
using System.Linq;

namespace uri2779 // Álbum da Copa
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int.TryParse(Console.ReadLine(), out int m);
            int[] figurinhas = new int[m];

            for (int i = 0; i < m; i++)
            {
                int.TryParse(Console.ReadLine(), out figurinhas[i]);
            }

            Console.WriteLine(n - figurinhas.Distinct().Count());
        }
    }
}