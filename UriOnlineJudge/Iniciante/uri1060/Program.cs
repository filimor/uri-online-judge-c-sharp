using System;

namespace uri1060 // Números Positivos
{
    internal static class Program
    {
        private static void Main()
        {
            double[] numero = new double[6];
            int positivos = 0;

            for (int i = 0; i <= 5; i++)
            {
                double.TryParse(Console.ReadLine(), out numero[i]);
                if (numero[i] > 0)
                {
                    positivos++;
                }
            }

            Console.WriteLine($"{positivos} valores positivos");
        }
    }
}
