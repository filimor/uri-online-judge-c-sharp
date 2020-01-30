using System;

namespace uri1182 // Coluna na Matriz
{
    internal static class Program
    {
        private static void Main()
        {
            double[,] m = new double[12, 12];
            int.TryParse(Console.ReadLine(), out int c);
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
                soma += m[k, c];
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