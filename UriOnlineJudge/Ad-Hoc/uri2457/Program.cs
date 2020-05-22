using System;
using System.Linq;

namespace uri2457
{
    static internal class Letras
    {
        private static void Main()
        {
            string letra = Console.ReadLine();
            string[] texto = Console.ReadLine().Split(' ');

            double result = texto.Count(palavra => palavra.Contains(letra));
            Console.WriteLine((result / texto.Length * 100).ToString("F1"));
        }
    }
}