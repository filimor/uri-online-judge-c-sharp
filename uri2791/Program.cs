using System;

namespace uri2791
{
    internal static class Feijao
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            if (str[0] == "1")
            {
                Console.WriteLine(1);
            }
            else if (str[1] == "1")
            {
                Console.WriteLine(2);
            }
            else if (str[2] == "1")
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
    }
}