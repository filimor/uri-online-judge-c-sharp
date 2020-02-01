using System;

namespace uri2163 // O Despertar da Força
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int n);
            int.TryParse(str[1], out int m);
            int x = 0;
            int y = 0;

            int[,] matriz = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    int.TryParse(str[j], out matriz[i, j]);
                }
            }

            for (int k = 0; k <= n - 3; k++)
            {
                for (int l = 0; l <= m - 3; l++)
                {
                    if (matriz[k, l] == 7 && matriz[k, l + 1] == 7 && matriz[k, l + 2] == 7 &&
                        matriz[k + 1, l] == 7 && matriz[k + 1, l + 1] == 42 && matriz[k + 1, l + 2] == 7 &&
                        matriz[k + 2, l] == 7 && matriz[k + 2, l + 1] == 7 && matriz[k + 2, l + 2] == 7)
                    {
                        x = k + 2;
                        y = l + 2;
                    }
                }
            }
            Console.WriteLine(x + " " + y);
        }
    }
}