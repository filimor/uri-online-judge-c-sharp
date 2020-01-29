using System;

namespace uri1145 // Sequência Lógica 2
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int x);
            int.TryParse(entrada[1], out int y);

            for (int i = 1; i <= y;)
            {
                for (int j = 1; j < x; j++)
                {
                    Console.Write($"{i++} ");
                }
                if (i <= y)
                {
                    Console.Write($"{i++}");
                }

                Console.WriteLine();
            }
        }
    }
}