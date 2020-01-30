using System;

namespace uri1789 // A Corrida de Lesmas
{
    internal static class Program
    {
        private static void Main()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                int.TryParse(str, out int l);
                string[] entrada = Console.ReadLine().Split(' ');
                int maior = 0;
                for (int i = 0; i < l; i++)
                {
                    int.TryParse(entrada[i], out int v);
                    if (v > maior)
                    {
                        maior = v;
                    }
                }
                if (maior < 10)
                {
                    Console.WriteLine(1);
                }
                else if (maior < 20)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(3);
                }
            }
        }
    }
}