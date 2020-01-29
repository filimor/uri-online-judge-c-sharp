using System;

namespace uri1164 // Número Perfeito
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int soma;

            for (int i = 1; i <= n; i++)
            {
                int.TryParse(Console.ReadLine(), out int x);
                soma = (x == 1) ? 0 : 1;

                for (int j = 2; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine($"{x} {((x == soma) ? "eh perfeito" : "nao eh perfeito")}");
            }
        }
    }
}