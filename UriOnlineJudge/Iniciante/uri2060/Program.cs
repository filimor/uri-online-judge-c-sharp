using System;

namespace uri2060 // Desafio de Bino
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] str = Console.ReadLine().Split(' ');
            int[] l = new int[n];
            int m2 = 0, m3 = 0, m4 = 0, m5 = 0;

            for (int i = 0; i < n; i++)
            {
                int.TryParse(str[i], out l[i]);
                if (l[i] % 2 == 0)
                {
                    m2++;
                }

                if (l[i] % 3 == 0)
                {
                    m3++;
                }

                if (l[i] % 4 == 0)
                {
                    m4++;
                }

                if (l[i] % 5 == 0)
                {
                    m5++;
                }
            }

            Console.WriteLine(m2 + " Multiplo(s) de 2");
            Console.WriteLine(m3 + " Multiplo(s) de 3");
            Console.WriteLine(m4 + " Multiplo(s) de 4");
            Console.WriteLine(m5 + " Multiplo(s) de 5");
        }
    }
}