using System;

namespace uri1564 // Vai Ter Copa?
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                int n = int.Parse(str);
                Console.WriteLine((n == 0) ? "vai ter copa!" : "vai ter duas!");
            }
        }
    }
}