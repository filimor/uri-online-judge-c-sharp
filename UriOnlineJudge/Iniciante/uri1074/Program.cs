using System;

namespace uri1074 // Par ou Ímpar
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; i <= n; i++)
            {
                int.TryParse(Console.ReadLine(), out int x);
                if (x == 0)
                {
                    Console.WriteLine("NULL");
                    continue;
                }
                else if (x % 2 == 0)
                {
                    Console.Write("EVEN");
                }
                else
                {
                    Console.Write("ODD");
                }

                if (x > 0)
                {
                    Console.Write(" POSITIVE\n");
                }
                else
                {
                    Console.Write(" NEGATIVE\n");
                }
            }
        }
    }
}