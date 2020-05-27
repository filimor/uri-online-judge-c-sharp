using System;

namespace uri2175 // Qual o Mais Rápido?
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            double.TryParse(str[0], out double o);
            double.TryParse(str[1], out double b);
            double.TryParse(str[2], out double i);

            if (o == b || b == i || o == i)
            {
                Console.WriteLine("Empate");
            }
            else if (o < b && o < i)
            {
                Console.WriteLine("Otavio");
            }
            else if (b < o && b < i)
            {
                Console.WriteLine("Bruno");
            }
            else
            {
                Console.WriteLine("Ian");
            }
        }
    }
}