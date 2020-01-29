using System;

namespace uri2395 // Transporte de Contêineres
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split();
            long.TryParse(str[0], out long a); // largura contâiner
            long.TryParse(str[1], out long b); // comprimento contâiner
            long.TryParse(str[2], out long c); // altura contâiner
            str = Console.ReadLine().Split();
            long.TryParse(str[0], out long x); // largura navio
            long.TryParse(str[1], out long y); // comprimento navio
            long.TryParse(str[2], out long z); // altura máxima

            if (a > x || b > y || c > z)
            {
                Console.WriteLine("0");
            }
            else
            {
                x -= x % a;
                y -= y % b;
                z -= z % c;
                Console.WriteLine(x * y * z / (a * b * c));
            }
        }
    }
}