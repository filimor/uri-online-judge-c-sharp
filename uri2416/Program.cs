using System;

namespace uri2416
{
    internal static class Corrida
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int c); // total corrida
            int.TryParse(str[1], out int n); // comprimento pista
            Console.WriteLine(c % n);
        }
    }
}