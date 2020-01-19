using System;

namespace uri1943
{
    internal static class TopN
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int k);
            if (k == 1)
            {
                Console.WriteLine("Top 1");
            }
            else if (k <= 3)
            {
                Console.WriteLine("Top 3");
            }
            else if (k <= 5)
            {
                Console.WriteLine("Top 5");
            }
            else if (k <= 10)
            {
                Console.WriteLine("Top 10");
            }
            else if (k <= 25)
            {
                Console.WriteLine("Top 25");
            }
            else if (k <= 50)
            {
                Console.WriteLine("Top 50");
            }
            else
            {
                Console.WriteLine("Top 100");
            }
        }
    }
}
