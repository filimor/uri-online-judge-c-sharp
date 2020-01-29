using System;

namespace uri1151 // Fibonacci Fácil
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            if (n == 1)
            {
                Console.Write("0");
            }
            else if (n == 2)
            {
                Console.Write("0 1");
            }
            else
            {
                Console.Write("0 1");
                int a = 0, b = 1;
                for (int i = 3; i <= n; i++)
                {
                    int soma = a + b;
                    Console.Write($" {soma}");
                    a = b;
                    b = soma;
                }
            }
            Console.Write("\n");
        }
    }
}