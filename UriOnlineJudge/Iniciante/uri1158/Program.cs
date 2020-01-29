using System;

namespace uri1158 // Soma de Ímpares Consecutivos III
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int soma;

            for (int m = 1; m <= n; m++)
            {
                soma = 0;
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int x);
                int.TryParse(entrada[1], out int y);

                for (int i = 1, j = x; i <= y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j; i++;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}