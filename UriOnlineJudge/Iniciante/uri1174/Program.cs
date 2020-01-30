using System;

namespace uri1174 // Seleçao em Vetor I
{
    internal static class Program
    {
        private static void Main()
        {
            double[] a = new double[100];
            for (int i = 0; i < a.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out a[i]);
            }
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] <= 10)
                {
                    Console.WriteLine($"A[{j}] = {a[j].ToString("F1")}");
                }
            }
        }
    }
}