using System;

namespace uri2950 // As Duas Torres
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            float.TryParse(str[0], out float n);
            float.TryParse(str[1], out float x);
            float.TryParse(str[2], out float y);
            Console.WriteLine((n / (x + y)).ToString("F2"));
        }
    }
}