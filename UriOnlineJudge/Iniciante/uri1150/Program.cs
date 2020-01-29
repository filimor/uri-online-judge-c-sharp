using System;

namespace uri1150 // Ultrapassando Z
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int x);
            int z;
            int i = 2;
            int soma = 0;

            do
            {
                int.TryParse(Console.ReadLine(), out z);
            } while (z <= x);

            for (int j = x + 1; ; i++, j++)
            {
                soma += j;
                if (soma + x > z)
                {
                    break;
                }
            }

            Console.WriteLine(i);
        }
    }
}