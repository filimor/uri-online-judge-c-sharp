using System;

namespace uri1890 // Emplacando os Tuk-tuks
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int.TryParse(str[0], out int c);
                int.TryParse(str[1], out int d);
                int placas = c == 0 && d == 0 ? 0 : 1;

                while (c > 0)
                {
                    placas *= 26;
                    c--;
                }

                while (d > 0)
                {
                    placas *= 10;
                    d--;
                }

                Console.WriteLine(placas);
            }
        }
    }
}