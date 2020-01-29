using System;

namespace uri1250
{
    internal static class KioMan
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                int atingido = 0;
                int.TryParse(Console.ReadLine(), out int t);
                string[] str = Console.ReadLine().Split(' ');
                int[] tiros = new int[t];
                for (int j = 0; j < t; j++)
                {
                    int.TryParse(str[j], out tiros[j]);
                }
                string pulos = Console.ReadLine();

                for (int k = 0; k < t; k++)
                {
                    if ((tiros[k] <= 2 && pulos[k] == 'S') ||
                        (tiros[k] > 2 && pulos[k] == 'J'))
                    {
                        atingido++;
                    }
                }

                Console.WriteLine(atingido);
            }
        }
    }
}