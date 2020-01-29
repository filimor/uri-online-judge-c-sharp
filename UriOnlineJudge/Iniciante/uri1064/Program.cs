using System;

namespace uri1064 // Positivos e Média
{
    internal static class Program
    {
        private static void Main()
        {
            double[] numero = new double[6];
            double soma = 0.0;
            int positivos = 0;

            for (int i = 0; i <= 5; i++)
            {
                double.TryParse(Console.ReadLine(), out numero[i]);
                if (numero[i] > 0)
                {
                    positivos++;
                    soma += numero[i];
                }
            }

            Console.WriteLine($"{positivos} valores positivos");
            Console.WriteLine((soma / positivos).ToString("F1"));
        }
    }
}