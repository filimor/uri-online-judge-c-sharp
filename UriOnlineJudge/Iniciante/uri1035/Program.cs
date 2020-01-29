using System;

namespace uri1035 // Teste de Seleção 1
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            int.TryParse(entrada[1], out int b);
            int.TryParse(entrada[2], out int c);
            int.TryParse(entrada[3], out int d);

            if ((b > c) &&
                (d > a) &&
                ((c + d) > (a + b)) &&
                (c > 0) &&
                (d > 0) &&
                ((a % 2) == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}