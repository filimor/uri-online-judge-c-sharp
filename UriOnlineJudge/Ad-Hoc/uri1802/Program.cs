// TODO: Incompleto

using System;

namespace uri1802 // Catálogo de Livros
{
    internal static class Program
    {
        private static void Main()
        {
            int soma = 0;

            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int p);
            int[] pV = new int[p];
            for (int i = 0; i < p; i++)
            {
                int.TryParse(str[i + 1], out pV[i]);
            }
            Array.Sort(pV);
            Array.Reverse(pV);

            str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int m);
            int[] mV = new int[m];
            for (int i = 0; i < m; i++)
            {
                int.TryParse(str[i + 1], out mV[i]);
            }
            Array.Sort(mV);
            Array.Reverse(mV);

            str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int f);
            int[] fV = new int[f];
            for (int i = 0; i < f; i++)
            {
                int.TryParse(str[i + 1], out fV[i]);
            }
            Array.Sort(fV);
            Array.Reverse(fV);

            str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int q);
            int[] qV = new int[q];
            for (int i = 0; i < q; i++)
            {
                int.TryParse(str[i + 1], out qV[i]);
            }
            Array.Sort(qV);
            Array.Reverse(qV);

            str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int b);
            int[] bV = new int[b];
            for (int i = 0; i < b; i++)
            {
                int.TryParse(str[i + 1], out bV[i]);
            }
            Array.Sort(bV);
            Array.Reverse(bV);

            int.TryParse(Console.ReadLine(), out int k);

            for (int j = 0; j < k; j++)
            {
                soma += pV[j] + mV[j] + fV[j] + qV[j] + bV[j];
            }

            Console.WriteLine(soma);
        }
    }
}