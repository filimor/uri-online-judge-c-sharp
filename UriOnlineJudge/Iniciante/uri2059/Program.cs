using System;

namespace uri2059 // Ímpar, Par ou Roubo
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int p);
            int.TryParse(entrada[1], out int j1);
            int.TryParse(entrada[2], out int j2);
            int.TryParse(entrada[3], out int r);
            int.TryParse(entrada[4], out int a);

            bool par = (j1 + j2) % 2 == 0;
            int vencedor = r == 1 && a == 1 ?
                2 : r == 1 && a == 0 ?
                1 : r == 0 && a == 1 ?
                1 : p == 1 && par ?
                1 : p == 0 && !par ?
                1 : 2;

            Console.WriteLine($"Jogador {vencedor} ganha!");
        }
    }
}