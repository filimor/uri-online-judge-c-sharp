using System;

namespace uri2483
{
    internal static class FelizNataaal
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int i);
            Console.Write("Feliz nat");
            for (int n = 0; n < i; n++)
            {
                Console.Write("a");
            }
            Console.WriteLine("l!");
        }
    }
}