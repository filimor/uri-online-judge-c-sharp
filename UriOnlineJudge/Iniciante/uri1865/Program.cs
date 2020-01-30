using System;

namespace uri1865 // Mjölnir
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int c);

            for (int i = 0; i < c; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                Console.WriteLine(entrada[0] == "Thor" ? "Y" : "N");
            }
        }
    }
}