using System;

namespace uri2497 // Contando Ciclos
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            int x = 1;

            while ((str = Console.ReadLine()) != "-1")
            {
                int.TryParse(str, out int n);
                Console.WriteLine($"Experiment {x++}: {n / 2} full cycle(s)");
            }
        }
    }
}