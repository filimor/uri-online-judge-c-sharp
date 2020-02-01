using System;

namespace uri2164 // Fibonacci Rápido
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            double fib = (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n)) / Math.Sqrt(5);
            Console.WriteLine(fib.ToString("F1"));
        }
    }
}