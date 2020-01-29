using System;

namespace uri1142 // PUM
{
    internal static class Program
    {
        private static void Main()
        {
            int a = 1, b = 2, c = 3;
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{a} {b} {c} PUM");
                a += 4;
                b += 4;
                c += 4;
            }
        }
    }
}