using System;

namespace uri1149 // Somando Inteiros Consecutivos
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            //int.TryParse(entrada[entrada.Length - 1], out int n);
            int.TryParse(entrada[^1], out int n);
            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += a + i;
            }

            Console.WriteLine(soma);
        }
    }
}