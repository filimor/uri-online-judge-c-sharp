using System;

namespace uri2028 // Sequência de Sequência
{
    internal static class Program
    {
        private static readonly int[][] n = new int[201][];
        private static readonly string[] s = new string[201];

        private static void Main()
        {
            int c = 1;
            string rl;
            for (int i = 0; i < n.Length; i++)
            {
                int l = 1;
                int a = (i * (i + 1) / 2) + 1;
                n[i] = new int[a];
                n[i][0] = 0;

                for (int k = 1; k <= i; k++)
                {
                    for (int j = 0; j < k; j++, l++)
                    {
                        n[i][l] = k;
                    }
                }
                s[i] = string.Join(" ", n[i]);
            }
            while (!string.IsNullOrEmpty(rl = Console.ReadLine()))
            {
                SolveProblem(c++, int.Parse(rl.Trim()));
            }
        }

        private static void SolveProblem(int cn, int nn)
        {
            int x = Program.n[nn].Length;
            if (x < 2)
            {
                Console.WriteLine("Caso {0}: {1} numero", cn, x);
            }
            else
            {
                Console.WriteLine("Caso {0}: {1} numeros", cn, x);
            }

            Console.WriteLine(s[nn]);
            Console.WriteLine();
        }
    }
}