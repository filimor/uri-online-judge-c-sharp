using System;

namespace uri2369 // Conta de Água
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int valor = 7;
            if (n > 100)
            {
                valor += (n - 100) * 5;
                n -= n - 100;
            }
            if (n > 30)
            {
                valor += (n - 30) * 2;
                n -= n - 30;
            }
            if (n > 10)
            {
                valor += n - 10;
            }
            Console.WriteLine(valor);
        }
    }
}
