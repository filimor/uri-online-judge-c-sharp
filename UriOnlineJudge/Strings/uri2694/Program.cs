using System;

namespace uri2694
{
    internal static class ProblemasComACalculadora
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                string entrada = Console.ReadLine();
                int.TryParse(entrada.Substring(2, 2), out int n1);
                int.TryParse(entrada.Substring(5, 3), out int n2);
                int.TryParse(entrada.Substring(11, 2), out int n3);
                Console.WriteLine(n1 + n2 + n3);
            }
        }
    }
}