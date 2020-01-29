using System;

namespace uri1113 // Crescente e Decrescente
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int x);
                int.TryParse(entrada[1], out int y);
                if (x == y)
                {
                    break;
                }

                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
            }
        }
    }
}