using System;

namespace uri1186 // Abaixo da Diagonal Secundária
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

            for (int x = 1; x < 12; x++)
            {
                for (int y = 11; y > 11 - x; y--)
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
                Console.WriteLine((soma / 66.0).ToString("F1"));
            }
        }
    }
}