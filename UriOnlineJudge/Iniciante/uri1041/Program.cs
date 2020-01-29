using System;
using System.Globalization;

namespace uri1041 // Coordenadas de um Ponto
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            float.TryParse(entrada[0], NumberStyles.Any, CultureInfo.InvariantCulture, out float x);
            float.TryParse(entrada[1], out float y);

            if (x > 0f)
            {
                if (y > 0f)
                {
                    Console.WriteLine("Q1");
                }
                else if (y < 0f)
                {
                    Console.WriteLine("Q4");
                }
                else
                {
                    Console.WriteLine("Eixo X");
                }
            }
            else if (x < 0f)
            {
                if (y > 0f)
                {
                    Console.WriteLine("Q2");
                }
                else if (y < 0f)
                {
                    Console.WriteLine("Q3");
                }
                else
                {
                    Console.WriteLine("Eixo X");
                }
            }
            else if (y == 0f)
            {
                Console.WriteLine("Origem");
            }
            else
            {
                Console.WriteLine("Eixo Y");
            }
        }
    }
}