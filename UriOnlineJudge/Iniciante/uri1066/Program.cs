using System;

namespace uri1066 // Pares, Ímpares, Positivos e Negativos
{
    internal static class Program
    {
        private static void Main()
        {
            int[] numero = new int[5];
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i <= 4; i++)
            {
                int.TryParse(Console.ReadLine(), out numero[i]);
                if (numero[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (numero[i] > 0)
                {
                    positivos++;
                }
                else if (numero[i] < 0)
                {
                    negativos++;
                }
            }

            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
        }
    }
}