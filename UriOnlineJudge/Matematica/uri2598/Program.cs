using System;

namespace uri2598 // Colocando Radares
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int c);
            for (int i = 0; i < c; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int n);
                double.TryParse(str[1], out double m);
                Console.WriteLine(Math.Ceiling(n / m));
            }
        }
    }
}