using System;

namespace uri1612 // Formiguinha
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                int.TryParse(Console.ReadLine(), out int n);
                Console.WriteLine(Math.Ceiling(n / 2.0));
            }
        }
    }
}