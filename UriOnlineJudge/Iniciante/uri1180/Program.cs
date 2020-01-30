using System;

namespace uri1180 // Menor e Posição
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[] x = new int[n];

            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out x[0]);
            int menor = x[0], posicao = 0;

            for (int i = 1; i < n; i++)
            {
                int.TryParse(entrada[i], out x[i]);
                if (x[i] < menor)
                {
                    menor = x[i];
                    posicao = i;
                }
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + posicao);
        }
    }
}