using System;

namespace uri1165 // Número Primo
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            bool primo;

            for (int i = 1; i <= n; i++)
            {
                primo = true;
                int.TryParse(Console.ReadLine(), out int x);
                if (x == 1)
                {
                    primo = false;
                }
                else
                {
                    for (int j = 2; j < x; j++)
                    {
                        if (x % j == 0)
                        {
                            primo = false;
                        }
                    }
                }
                Console.WriteLine($"{x} {(primo ? "eh" : "nao eh")} primo");
            }
        }
    }
}