using System;

namespace uri2377
{
    internal static class Pedagio
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int l); // comprimento da estrada
            int.TryParse(str[1], out int d); // distância entre pedágios
            str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int k); // custo por quilômetro
            int.TryParse(str[1], out int p); // valor do pedágio

            int custo = (l * k) + (l / d * p);
            Console.WriteLine(custo);
        }
    }
}