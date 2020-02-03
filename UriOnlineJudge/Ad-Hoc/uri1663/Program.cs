using System;
using System.Linq;

namespace uri1663 // Permutações Ambíguas
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
                int[] permutacao = new int[n];
                int[] inversa = new int[n];

                for (int i = 0; i < n; i++)
                {
                    int.TryParse(entrada[i], out permutacao[i]);
                }

                for (int j = 0; j < n; j++)
                {
                    inversa[permutacao[j] - 1] = j + 1;
                }

                Console.WriteLine(permutacao.SequenceEqual(inversa) ?
                    "ambiguous" : "not ambiguous");
            }
        }
    }
}