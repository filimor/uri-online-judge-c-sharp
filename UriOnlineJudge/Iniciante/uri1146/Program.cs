using System;

namespace uri1146 // Sequências Crescentes
{
    internal static class Program
    {
        private static void Main()
        {
            int x;
            do
            {
                int.TryParse(Console.ReadLine(), out x);
                for (int i = 1; i < x; i++)
                {
                    Console.Write($"{i} ");
                }
                if (x != 0)
                {
                    Console.WriteLine($"{x}");
                }
            } while (x != 0);
        }
    }
}