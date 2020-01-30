using System;

namespace uri1181 // Linha na Matriz
{
    internal static class Program
    {
        private static void Main()
        {
            double[,] m = new double[12, 12];
            int.TryParse(Console.ReadLine(), out int l);
            string t = Console.ReadLine();
            double soma = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    double.TryParse(Console.ReadLine(), out m[i, j]);
                }
            }

            for (int k = 0; k < 12; k++)
            {
                soma += m[l, k];
            }

            if (t == "S")
            {
                Console.WriteLine(soma.ToString("F1"));
            }
            else
            {
                Console.WriteLine((soma / 12.0).ToString("F1"));
            }
        }
    }
}