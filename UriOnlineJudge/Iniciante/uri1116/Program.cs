using System;

namespace uri1116 // Dividindo X por Y
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 1; i <= n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out int x);
                int.TryParse(entrada[1], out int y);
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((x / (double)y).ToString("F1"));
                }
            }
        }
    }
}