using System;

namespace uri2556
{
    internal static class Program // Reinauguração do CEI
    {
        private static void Main()
        {
            string entrada;

            while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
            {
                int.TryParse(entrada, out int n);
                string[] str = Console.ReadLine().Split(' ');
                int[] m = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int.TryParse(str[i], out m[i]);
                }
                Array.Sort(m);
                Console.WriteLine($"{n / 2} {m[n / 2] - m[(n / 2) - 1]}");
            }
        }
    }
}