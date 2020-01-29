using System;

namespace uri1095 // Sequencia IJ 1
{
    internal static class Program
    {
        private static void Main()
        {
            for (int i = 1, j = 60; j >= 0; i += 3)
            {
                Console.WriteLine($"I={i} J={j}");
                j -= 5;
            }
        }
    }
}