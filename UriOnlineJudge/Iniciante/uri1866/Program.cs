using System;

namespace uri1866 // Conta
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int c);
            for (int i = 0; i < c; i++)
            {
                int.TryParse(Console.ReadLine(), out int n);
                Console.WriteLine((n % 2 == 0) ? 0 : 1);
            }
        }
    }
}