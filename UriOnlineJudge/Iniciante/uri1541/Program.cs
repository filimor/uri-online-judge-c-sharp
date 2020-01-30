using System;

namespace uri1541 // Construindo Casas
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            while (a != 0)
            {
                int.TryParse(entrada[1], out int b);
                int.TryParse(entrada[2], out int c);

                Console.WriteLine(Math.Truncate(Math.Sqrt(a * b * 100 / c)));

                entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out a);
            }
        }
    }
}