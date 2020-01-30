using System;

namespace uri1534 // Matriz 123
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            while (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j + i == n - 1)
                        {
                            Console.Write("2");
                        }
                        else if (i == j)
                        {
                            Console.Write("1");
                        }
                        else
                        {
                            Console.Write("3");
                        }
                    }
                    Console.WriteLine();
                }
                int.TryParse(Console.ReadLine(), out n);
            }
        }
    }
}