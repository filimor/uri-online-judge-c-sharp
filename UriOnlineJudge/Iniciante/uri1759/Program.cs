using System;

namespace uri1759 // Ho Ho Ho
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("Ho ");
            }
            if (n != 0)
            {
                Console.WriteLine("Ho!");
            }
        }
    }
}