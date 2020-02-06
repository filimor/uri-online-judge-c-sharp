using System;

namespace uri1793 // Escada Rolante
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while ((str = Console.ReadLine()) != "0")
            {
                int.TryParse(str, out int n);
                string[] entrada = Console.ReadLine().Split(' ');
                int[] tempos = new int[n];
                int.TryParse(entrada[0], out tempos[0]);
                int total = 10;

                for (int i = 1; i < n; i++)
                {
                    int.TryParse(entrada[i], out tempos[i]);
                    if (tempos[i] - tempos[i - 1] > 10)
                    {
                        total += 10;
                    }
                    else
                    {
                        total += tempos[i] - tempos[i - 1];
                    }
                }

                Console.WriteLine(total);
            }
        }
    }
}