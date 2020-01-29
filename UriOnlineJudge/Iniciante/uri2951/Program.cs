using System;
using System.Collections.Generic;

namespace uri2951 // O Retorno do Rei
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int n);
            int.TryParse(str[1], out int g);
            var runas = new Dictionary<string, int>();
            int amizade = 0;

            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                int.TryParse(linha[1], out int v);
                runas.Add(linha[0], v);
            }

            int.TryParse(Console.ReadLine(), out int x);
            string[] recitadas = Console.ReadLine().Split(' ');

            for (int i = 0; i < x; i++)
            {
                if (runas.ContainsKey(recitadas[i]))
                {
                    amizade += runas[recitadas[i]];
                }
            }

            Console.WriteLine(amizade >= g ? $"{amizade}\nYou shall pass!" :
                $"{amizade}\nMy precioooous");
        }
    }
}