using System;

namespace uri1080 // Maior e Posição
{
    internal static class Program
    {
        private static void Main()
        {
            int maior = 0;
            int posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                int.TryParse(Console.ReadLine(), out int numero);
                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }
            Console.WriteLine($"{maior}\n{posicao}");
        }
    }
}