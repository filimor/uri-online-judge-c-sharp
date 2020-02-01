using System;

namespace uri2143 // A Volta do Radar
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while ((str = Console.ReadLine()) != "0")
            {
                int.TryParse(str, out int t);
                for (int i = 0; i < t; i++)
                {
                    int.TryParse(Console.ReadLine(), out int n);
                    int pedidos = (n - 1) % 2 == 0 ?
                        (2 * n) - 1 : (2 * n) - 2;
                    Console.WriteLine(pedidos);
                }
            }
        }
    }
}