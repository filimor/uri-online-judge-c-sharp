using System;

namespace uri1858 // A Resposta de Theon
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] entrada = Console.ReadLine().Split(' ');
            int[] pessoa = new int[n];
            int menor = 20;
            int resposta = 0;
            for (int i = 0; i < n; i++)
            {
                int.TryParse(entrada[i], out pessoa[i]);
                if (pessoa[i] < menor)
                {
                    menor = pessoa[i];
                    resposta = i + 1;
                }
            }
            Console.WriteLine(resposta);
        }
    }
}