using System;

namespace uri1467 // Zerinho ou Um
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                if (str[0] != str[2] && str[0] != str[4])
                {
                    Console.WriteLine("A");
                }
                else if (str[2] != str[0] && str[2] != str[4])
                {
                    Console.WriteLine("B");
                }
                else if (str[4] != str[0] && str[4] != str[2])
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}