using System;
using System.Linq;

namespace uri2534
{
    internal static class ExameGeral
    {
        private static void Main()
        {
            string entrada = Console.ReadLine();
            while (!string.IsNullOrEmpty(entrada))
            {
                string[] str = entrada.Split(' ');
                int.TryParse(str[0], out int n);
                int.TryParse(str[1], out int q);
                int[] p = new int[n];

                for (int i = 0; i < n; i++)
                {
                    int.TryParse(Console.ReadLine(), out p[i]);
                }

                p = p.OrderByDescending(x => x).ToArray();

                for (int j = 0; j < q; j++)
                {
                    int.TryParse(Console.ReadLine(), out int posicao);
                    Console.WriteLine(p[posicao - 1]);
                }

                entrada = Console.ReadLine();
            }
        }
    }
}