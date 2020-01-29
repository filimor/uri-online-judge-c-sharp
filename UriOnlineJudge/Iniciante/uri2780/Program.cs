using System;

namespace uri2780
{
    internal static class BasqueteDeRobos
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int d);
            if (d <= 800)
            {
                Console.WriteLine("1");
            }else if (d <= 1400)
            {
                Console.WriteLine("2");
            }else
            {
                Console.WriteLine("3");
            }
        }
    }
}