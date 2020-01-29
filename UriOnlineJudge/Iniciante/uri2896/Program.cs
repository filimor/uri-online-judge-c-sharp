using System;

namespace uri2896
{
    internal static class AproveiteAOferta
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int n);
                int.TryParse(str[1], out int k);
                Console.WriteLine((n / k) + (n % k));
            }
        }
    }
}