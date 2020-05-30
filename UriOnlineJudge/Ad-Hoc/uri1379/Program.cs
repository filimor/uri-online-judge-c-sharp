using System;

namespace uri1379 // Problema com Mediana e Média
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while ((str = Console.ReadLine()) != "0 0")
            {
                string[] entrada = str.Split(' ');
                int.TryParse(entrada[0], out int a);
                int.TryParse(entrada[1], out int b);
                int maior = Math.Max(a, b);
                int menor = Math.Min(a, b);
                int x = maior - menor;
                Console.WriteLine(menor - x);
            }
        }
    }
}