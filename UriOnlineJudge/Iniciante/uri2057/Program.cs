using System;

namespace uri2057 // Fuso Horário
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int s);
            int.TryParse(entrada[1], out int t);
            int.TryParse(entrada[2], out int f);
            int r = s + t + f;
            if (s > t && r >= 24)
            {
                r -= 24;
            }
            if (s < t && r < 0)
            {
                r += 24;
            }
            Console.WriteLine(r);
        }
    }
}