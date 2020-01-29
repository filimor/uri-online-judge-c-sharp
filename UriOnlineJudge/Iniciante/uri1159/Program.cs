using System;

namespace uri1159 // Soma de Pares Consecutivos
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int numero);
            while (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{(5 * numero) + 20}");
                }
                else
                {
                    Console.WriteLine($"{(5 * numero) + 25}");
                }
                int.TryParse(Console.ReadLine(), out numero);
            }
        }
    }
}