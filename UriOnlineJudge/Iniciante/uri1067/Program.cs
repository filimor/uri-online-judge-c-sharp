using System;

namespace uri1067 // Números Ímpares
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int x);
            for (int i = 1; i <= x; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}