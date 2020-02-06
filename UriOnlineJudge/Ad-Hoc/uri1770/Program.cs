// TODO: Incompleto

using System;
using System.Collections.Generic;

namespace uri1770 // Shuffle
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                string[] entrada = str.Split(' ');
                int.TryParse(entrada[0], out int m);
                int.TryParse(entrada[1], out int k);
                int tempo = 0;
                var tocadas = new List<int>();
                bool impossivel = false;

                entrada = Console.ReadLine().Split(' ');
                int[] duracoes = new int[m];
                for (int i = 0; i < m; i++)
                {
                    int.TryParse(entrada[i], out duracoes[i]);
                }

                entrada = Console.ReadLine().Split(' ');
                int[] musicas = new int[k];
                for (int i = 0; i < k; i++)
                {
                    int.TryParse(entrada[i], out musicas[i]);
                    tempo += duracoes[musicas[i] - 1];
                    tocadas.Add(i);
                }

                for (int i = 0; i < m; i++)
                {
                    if (!tocadas.Contains(i))
                    {
                        impossivel = true;
                    }
                }

                Console.WriteLine(impossivel ? -1 : tempo);
            }
        }
    }
}