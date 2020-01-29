using System;

namespace uri1013 // O Maior
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int a);
            int.TryParse(entrada[1], out int b);
            int.TryParse(entrada[2], out int c);
            int maiorAb = (a + b + Math.Abs(a - b)) / 2;
            int maiorNumero = (maiorAb + c + Math.Abs(maiorAb - c)) / 2;
            Console.WriteLine($"{maiorNumero} eh o maior");
        }
    }
}