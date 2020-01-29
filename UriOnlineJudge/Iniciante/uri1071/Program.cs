using System;

namespace uri1071 // Soma de Impares Consecutivos I
{
    internal static class Program
    {
        private static void Main()
        {
            int soma = 0;
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);

            for (int i = ((x < y) ? x : y) + 1; i < ((x < y) ? y : x); i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}