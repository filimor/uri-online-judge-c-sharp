using System;

namespace uri1101 // Sequência de Números e Soma
{
    internal static class Program
    {
        private static void Main()
        {
            int menor, maior;
            int soma = 0;

            while (true)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int m);
                int.TryParse(entrada[1], out int n);

                if (m <= 0 || n <= 0)
                {
                    break;
                }

                if (m > n)
                {
                    maior = m;
                    menor = n;
                }
                else
                {
                    maior = n;
                    menor = m;
                }

                for (int i = menor; i <= maior; i++)
                {
                    Console.Write($"{i} ");
                    soma += i;
                }

                Console.WriteLine($"Sum={soma}");
                soma = 0;
            }
        }
    }
}