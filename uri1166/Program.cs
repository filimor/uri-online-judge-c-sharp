using System;

namespace uri1166
{
    internal static class TorreDeHanoiNovamente
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                int resultado = 1;
                int x = 2;
                int.TryParse(Console.ReadLine(), out int n);

                if (n == 1)
                {
                    Console.WriteLine(1);
                    continue;
                }

                for (int j = 2; j <= n; j++)
                {
                    resultado += x;
                    if (j % 2 == 0)
                    {
                        x += 2;
                    }
                }

                Console.WriteLine(resultado);
            }
        }
    }
}