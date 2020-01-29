// Incompleto

using System;

namespace uri1366 // Jogo de Varetas
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while ((str = Console.ReadLine()) != "0")
            {
                int.TryParse(str, out int n);
                int[,] varetas = new int[n, 2];

                for (int i = 0; i < n; i++)
                {
                    string[] linha = Console.ReadLine().Split(' ');
                    int.TryParse(linha[0], out varetas[n, 0]);
                    int.TryParse(linha[1], out varetas[n, 1]);
                }
            }
        }
    }
}