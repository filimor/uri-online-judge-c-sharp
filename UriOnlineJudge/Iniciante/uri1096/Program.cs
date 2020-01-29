using System;

namespace uri1096 // Sequencia IJ 2
{
    internal static class Program
    {
        private static void Main()
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
        }
    }
}