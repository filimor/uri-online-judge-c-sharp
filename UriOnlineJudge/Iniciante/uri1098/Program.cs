using System;

namespace uri1098 // Sequencia IJ 4
{
    internal static class Program
    {
        private static void Main()
        {
            for (double i = 0; i <= 2; i += 0.2)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"I={i} J={j + i}");
                }
            }
        }
    }
}