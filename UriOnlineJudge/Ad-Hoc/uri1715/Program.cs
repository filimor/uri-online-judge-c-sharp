using System;

namespace uri1715 // Handebol
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int n);
            int.TryParse(str[1], out int m);
            int partidas = 0;

            for (int i = 0; i < n; i++)
            {
                bool golsEmTodas = true;
                str = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    int.TryParse(str[j], out int gols);
                    if (gols == 0)
                    {
                        golsEmTodas = false;
                    }
                }
                if (golsEmTodas)
                {
                    partidas++;
                }
            }

            Console.WriteLine(partidas);
        }
    }
}