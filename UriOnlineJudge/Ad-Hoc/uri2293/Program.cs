using System;

namespace uri2293 // Campo de Minhocas
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int n);
            int.TryParse(str[1], out int m);
            int[,] mat = new int[n, m];
            int maior = 0;

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    int.TryParse(str[j], out mat[i, j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                int soma = 0;
                for (int k = 0; k <= mat.GetUpperBound(1); k++)
                {
                    soma += mat[i, k];
                }
                if (soma > maior)
                {
                    maior = soma;
                }
            }

            for (int j = 0; j < m; j++)
            {
                int soma = 0;
                for (int l = 0; l <= mat.GetUpperBound(0); l++)
                {
                    soma += mat[l, j];
                }
                if (soma > maior)
                {
                    maior = soma;
                }
            }

            Console.WriteLine(maior);
        }
    }
}