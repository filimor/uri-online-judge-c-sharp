using System;

namespace uri2342 // Overflow
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int p);
            string c = entrada[1];
            int.TryParse(entrada[2], out int q);

            if (c == "+")
            {
                Console.WriteLine(p + q > n ? "OVERFLOW" : "OK");
            }
            else if (c == "*")
            {
                Console.WriteLine(p * q > n ? "OVERFLOW" : "OK");
            }
        }
    }
}