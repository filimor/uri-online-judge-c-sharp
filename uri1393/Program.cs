using System;

namespace uri1393
{
    internal static class LajotasHexagonais
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            while (n != 0)
            {
                Console.WriteLine(Funcao(n));
                int.TryParse(Console.ReadLine(), out n);
            }
        }

        private static int Funcao(int x)
        {
            return x == 1 || x == 2 || x == 3 ? x : Funcao(x - 1) + Funcao(x - 2);
        }
    }
}

// f(x) = f(x-1) + f(x-2)