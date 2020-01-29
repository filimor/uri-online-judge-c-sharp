using System;

namespace uri1065 // Pares entre Cinco Números
{
    internal static class Program
    {
        private static void Main()
        {
            int[] numero = new int[5];
            int pares = 0;

            for (int i = 0; i <= 4; i++)
            {
                int.TryParse(Console.ReadLine(), out numero[i]);
                if (numero[i] % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine($"{pares} valores pares");
        }
    }
}