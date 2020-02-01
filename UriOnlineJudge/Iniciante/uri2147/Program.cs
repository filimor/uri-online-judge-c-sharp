using System;

namespace uri2147 // Galopeira
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int c);
            for (int i = 0; i < c; i++)
            {
                string str = Console.ReadLine();
                double t = str.Length;
                Console.WriteLine((t / 100.0).ToString("F2"));
            }
        }
    }
}