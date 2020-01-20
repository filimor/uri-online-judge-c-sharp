using System;

namespace uri2434 // Saldo do Vovô
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int n);
            int.TryParse(entrada[1], out int s);
            int menorValor = s;
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int x);
                s += x;
                if (s < menorValor)
                {
                    menorValor = s;
                }
            }
            Console.WriteLine(menorValor);
        }
    }
}