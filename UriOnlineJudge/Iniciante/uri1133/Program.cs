using System;

namespace uri1133 // Resto da Divisão
{
    internal static class Program
    {
        private static void Main()
        {
            int maior, menor;
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);

            if (x > y)
            {
                maior = x;
                menor = y;
            }
            else
            {
                maior = y;
                menor = x;
            }

            for (int i = menor + 1; i < maior; i++)
            {
                if ((i % 5 == 2) || (i % 5 == 3))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}