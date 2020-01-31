using System;

namespace uri1929 // Triângulo
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            int.TryParse(entrada[1], out int b);
            int.TryParse(entrada[2], out int c);
            int.TryParse(entrada[3], out int d);

            if (ExisteTriangulo(a, b, c) ||
                ExisteTriangulo(a, b, d) ||
                ExisteTriangulo(a, c, d) ||
                ExisteTriangulo(b, c, d))
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }

        private static bool ExisteTriangulo(int a, int b, int c)
        {
            return Math.Abs(b - c) < a &&
                a < b + c &&
                Math.Abs(a - c) < b
                && b < a + c &&
                Math.Abs(a - b) < c
                && c < a + b;
        }
    }
}