// Não passa em todos os casos de teste.

using System;

namespace uri1300 // Horas e Minutos
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int a);
                bool existe = false;

                for (int h = 1; h <= 12; h++)
                {
                    for (int m = 0; m <= 59; m++)
                    {
                        if (a == 360 - (Math.Abs((11 * m) - (60 * h)) / 2))
                        {
                            existe = true;
                        }
                    }
                }

                Console.WriteLine(existe ? "Y" : "N");
            }
        }
    }
}