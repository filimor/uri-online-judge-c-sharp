using System;

namespace uri1097 // Sequencia IJ 3
{
    internal static class Program
    {
        private static void Main()
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = i + 6; j >= i + 4; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
        }
    }
}