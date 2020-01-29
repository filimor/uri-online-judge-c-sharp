using System;

namespace uri1323
{
    internal static class Feynman
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            while (n != 0)
            {
                int quadrados = 0;
                for (int i = 1; i <= n; i++)
                {
                    quadrados += i * i;
                }
                Console.WriteLine(quadrados);
                int.TryParse(Console.ReadLine(), out n);
            }
        }
    }
}