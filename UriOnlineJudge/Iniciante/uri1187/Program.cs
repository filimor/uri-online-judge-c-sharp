using System;

namespace uri1187 // Área Superior
{
    internal static class Program
    {
        private static void Main()
        {
            double[,] m = new double[12, 12];
            double soma = 0;

            string o = Console.ReadLine();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    double.TryParse(Console.ReadLine(), out m[i, j]);
                }
            }

            for (int x = 0; x < 5; x++)
            {
                for (int y = x + 1; y < 11 - x; y++)
                {
                    soma += m[x, y];
                }
            }

            if (o == "S")
            {
                Console.WriteLine(soma.ToString("F1"));
            }
            else
            {
                Console.WriteLine((soma / 30.0).ToString("F1"));
            }
        }
    }
}