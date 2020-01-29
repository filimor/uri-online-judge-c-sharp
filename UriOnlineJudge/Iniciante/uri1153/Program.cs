using System;

namespace uri1153 // Fatorial Simples
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int fatorial = n;
            for (int i = 1; i < n; i++)
            {
                fatorial *= n - i;
            }
            Console.WriteLine(fatorial);
        }
    }
}