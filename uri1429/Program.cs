using System;

namespace uri1429
{
    internal static class FatorialDeNovo
    {
        private static void Main()
        {
            string str = Console.ReadLine();
            while (str != "0")
            {
                int acm = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    acm += int.Parse(str[i].ToString()) *
                        Fatorial(str.Length - i);
                }
                Console.WriteLine(acm);
                str = Console.ReadLine();
            }
        }

        private static int Fatorial(int x)
        {
            int resultado = 1;
            for (int i = 1; i <= x; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}