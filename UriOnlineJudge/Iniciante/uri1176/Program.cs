using System;

namespace uri1176 // Fibonacci em Vetor
{
    internal static class Program
    {
        private static void Main()
        {
            //Inicializa a Série de Fibonacci
            ulong[] Fib = new ulong[61];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i < Fib.Length; i++)
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
            }

            //Exibe os valores solicitados
            int.TryParse(Console.ReadLine(), out int t);
            for (int j = 0; j < t; j++)
            {
                int.TryParse(Console.ReadLine(), out int x);
                Console.WriteLine($"Fib({x}) = {Fib[x]}");
            }
        }
    }
}