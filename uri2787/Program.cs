using System;

namespace uri2787
{
    internal static class Xadrez
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int l);
            int.TryParse(Console.ReadLine(), out int c);
            if ((l + c) % 2 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}