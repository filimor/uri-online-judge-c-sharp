using System;

namespace uri2963 // Bobo da Corte
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[] votos = new int[n];
            bool eleito = true;

            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out votos[i]);
                if (votos[i] > votos[0])
                {
                    eleito = false;
                }
            }

            Console.WriteLine(eleito ? "S" : "N");
        }
    }
}