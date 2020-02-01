using System;

namespace uri2162 // Picos e Vales
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            string[] str = Console.ReadLine().Split(' ');
            int[] h = new int[n];
            bool padrao = true;
            bool pico = false;

            int.TryParse(str[0], out h[0]);
            int.TryParse(str[1], out h[1]);

            if (h[1] > h[0])
            {
                pico = true;
                for (int i = 2; i < n; i++)
                {
                    int.TryParse(str[i], out h[i]);
                    if (pico && h[i] >= h[i - 1])
                    {
                        padrao = false;
                    }

                    if (!pico && h[i] <= h[i - 1])
                    {
                        padrao = false;
                    }

                    pico = !pico;
                }
            }
            else if (h[0] > h[1])
            {
                for (int i = 2; i < n; i++)
                {
                    int.TryParse(str[i], out h[i]);
                    if (pico && h[i] >= h[i - 1])
                    {
                        padrao = false;
                    }

                    if (!pico && h[i] <= h[i - 1])
                    {
                        padrao = false;
                    }

                    pico = !pico;
                }
            }
            else
            {
                padrao = false;
            }

            Console.WriteLine(padrao ? "1" : "0");
        }
    }
}