using System;

namespace uri2862 // Inseto!
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int c);
            for (int i = 0; i < c; i++)
            {
                int.TryParse(Console.ReadLine(), out int n);
                Console.WriteLine(n > 8000 ? "Mais de 8000!" : "Inseto!");
            }
        }
    }
}
