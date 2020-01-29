using System;

namespace uri1072 // Intervalo 2
{
    internal static class Program
    {
        private static void Main()
        {
            int dentro = 0;
            int fora = 0;
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; i <= n; i++)
            {
                int.TryParse(Console.ReadLine(), out int x);
                if ((x >= 10) && (x <= 20))
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} in\n{fora} out");
        }
    }
}