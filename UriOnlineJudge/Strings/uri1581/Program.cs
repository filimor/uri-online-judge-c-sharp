using System;

namespace uri1581 // Conversa Internacional
{
    internal static class Program
    {
        internal static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int k);
                string s = Console.ReadLine();

                for (int j = 1; j < k; j++)
                {
                    if (Console.ReadLine() != s)
                    {
                        s = "ingles";
                    }
                }

                Console.WriteLine(s);
            }
        }
    }
}