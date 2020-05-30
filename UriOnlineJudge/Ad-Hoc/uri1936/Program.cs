using System;

namespace uri1936 // Fatorial
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int maiorFatorial = 1;
            int k;

            for (k = 0; n > 0; k++)
            {
                for (int i = 1; i <= n; i++)
                {
                    int x = Fatorial(i);
                    if (x > n)
                    {
                        break;
                    }
                    maiorFatorial = x;
                }
                n -= maiorFatorial;
            }

            Console.WriteLine(k);
        }

        private static int Fatorial(int x)
        {
            return x == 0 ? 1 : x * Fatorial(x - 1);
        }
    }
}