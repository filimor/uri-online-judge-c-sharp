using System;

namespace uri2396 // Corrida
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int n);
            int.TryParse(str[1], out int m);
            int[] tempos = new int[n];
            int tempoSt = int.MaxValue, tempoNd = int.MaxValue, tempoRd = int.MaxValue;
            int st = 1, nd = 1, rd = 1;

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    int.TryParse(str[j], out int volta);
                    tempos[i] += volta;
                }
                if (tempos[i] < tempoSt)
                {
                    rd = nd;
                    tempoRd = tempoNd;
                    nd = st;
                    tempoNd = tempoSt;
                    st = i + 1;
                    tempoSt = tempos[i];
                }
                else if (tempos[i] < tempoNd)
                {
                    rd = nd;
                    tempoRd = tempoNd;
                    nd = i + 1;
                    tempoNd = tempos[i];
                }
                else if (tempos[i] < tempoRd)
                {
                    rd = i + 1;
                    tempoRd = tempos[i];
                }
            }

            Console.WriteLine($"{st}\n{nd}\n{rd}");
        }
    }
}