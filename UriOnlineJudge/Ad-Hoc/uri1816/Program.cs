// TODO: Incompleto

using System;
using System.Collections.Generic;

namespace uri1816 // Vikings em Praga?
{
    internal static class Program
    {
        private static void Main()
        {
            int h = 1;
            var alfabeto = new List<char>();
            for (int i = 0; i < 26; i++)
            {
                alfabeto.Add(Convert.ToChar(i + 65));
            }

            string str;
            while ((str = Console.ReadLine()) != "0")
            {
                int.TryParse(str, out int m);
                m *= 2;
                string texto = string.Empty;

                string[] entrada = Console.ReadLine().Split(' ');

                for (int i = 0; i < m; i += 2)
                {
                    int.TryParse(entrada[i], out int n);
                    char c = alfabeto[n];
                    texto += c.ToString();
                    alfabeto.RemoveAt(n);
                    alfabeto.Insert(0, c);
                }

                if (h != 1)
                {
                    Console.WriteLine();
                }
                Console.WriteLine($"Instancia {h++}");
                Console.WriteLine(texto);
            }
        }
    }
}