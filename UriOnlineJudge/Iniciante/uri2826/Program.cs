using System;

namespace uri2826 // Léxico
{
    internal static class Program
    {
        private static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (string.Compare(a, b) <= 0)
            {
                Console.WriteLine($"{a}\n{b}");
            }
            else
            {
                Console.WriteLine($"{b}\n{a}");
            }
        }
    }
}