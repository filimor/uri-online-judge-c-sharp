using System;

namespace uri2807 // Iccanobif
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[] sequencia = new int[n];
            sequencia[0] = 1;
            if (n >= 2)
            {
                sequencia[1] = 1;
            }

            for (int i = 2; i < n; i++)
            {
                sequencia[i] = sequencia[i - 1] + sequencia[i - 2];
            }

            Array.Reverse(sequencia);

            Console.Write(sequencia[0]);

            for (int i = 1; i < n; i++)
            {
                Console.Write($" {sequencia[i]}");
            }

            Console.WriteLine();
        }
    }
}