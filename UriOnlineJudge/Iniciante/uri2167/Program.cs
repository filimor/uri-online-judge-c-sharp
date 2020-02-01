using System;

namespace uri2167 // Falha do Motor
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] str = Console.ReadLine().Split(' ');
            int[] r = new int[n];
            int queda = 0;

            int.TryParse(str[0], out r[0]);
            for (int i = 1; i < n; i++)
            {
                int.TryParse(str[i], out r[i]);
                if (r[i] < r[i - 1] && queda == 0)
                {
                    queda = i + 1;
                }
            }

            Console.WriteLine(queda);
        }
    }
}