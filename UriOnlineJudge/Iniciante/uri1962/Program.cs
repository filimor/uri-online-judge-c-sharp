using System;

namespace uri1962 // Há Muito, Muito Tempo Atrás
{
    internal static class Program
    {
        private static void Main()
        {
            const int ANO = 2015;
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int t);
                if (t > ANO)
                {
                    Console.WriteLine(t - ANO + 1 + " A.C.");
                }
                else if (t < ANO)
                {
                    Console.WriteLine(ANO - t + " D.C.");
                }
                else
                {
                    Console.WriteLine("1 A.C.");
                }
            }
        }
    }
}