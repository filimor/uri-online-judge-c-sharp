using System;

namespace uri1154 // Idades
{
    internal static class Program
    {
        private static void Main()
        {
            double soma = 0;
            int quantidade = 0;
            for (; ; quantidade++)
            {
                int.TryParse(Console.ReadLine(), out int idade);
                if (idade < 0)
                {
                    break;
                }

                soma += idade;
            }
            if (quantidade != 0)
            {
                Console.WriteLine((soma / quantidade).ToString("F2"));
            }
        }
    }
}