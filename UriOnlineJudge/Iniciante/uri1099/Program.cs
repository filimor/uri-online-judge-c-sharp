using System;

namespace uri1099 // Soma de Ímpares Consecutivos II
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int menor, maior;
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int x);
                int.TryParse(entrada[1], out int y);

                if (x > y)
                {
                    maior = x;
                    menor = y;
                }
                else
                {
                    maior = y;
                    menor = x;
                }

                for (int j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}