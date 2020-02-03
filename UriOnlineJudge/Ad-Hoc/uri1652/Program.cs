using System;
using System.Collections.Generic;

namespace uri1652 // Deli Deli
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int.TryParse(str[0], out int l);
            int.TryParse(str[1], out int n);
            var irregulares = new Dictionary<string, string>();
            string[] palavras = new string[n];

            for (int i = 0; i < l; i++)
            {
                str = Console.ReadLine().Split(' ');
                irregulares.Add(str[0], str[1]);
            }

            for (int j = 0; j < n; j++)
            {
                palavras[j] = Console.ReadLine();
            }

            foreach (string palavra in palavras)
            {
                int tamanho = palavra.Length;

                if (irregulares.ContainsKey(palavra))
                {
                    Console.WriteLine(irregulares[palavra]);
                }
                else if (palavra[^1] == 'y' &&
                    palavra[^2] != 'a' &&
                    palavra[^2] != 'e' &&
                    palavra[^2] != 'i' &&
                    palavra[^2] != 'o' &&
                    palavra[^2] != 'u')
                {
                    Console.WriteLine(palavra.Substring(0, tamanho - 1) + "ies");
                }
                else if (palavra[^1] == 'o' ||
                    palavra[^1] == 's' ||
                    palavra[^1] == 'x')
                {
                    Console.WriteLine(palavra + "es");
                }
                else if (palavra.Substring(tamanho - 2, 2) == "ch" ||
                    palavra.Substring(tamanho - 2, 2) == "sh")
                {
                    Console.WriteLine(palavra + "es");
                }
                else
                {
                    Console.WriteLine(palavra + "s");
                }
            }
        }
    }
}

// Pre-C# 8 loop version:

//foreach (string palavra in palavras)
//{
//    int tamanho = palavra.Length;

//    if (irregulares.ContainsKey(palavra))
//    {
//        Console.WriteLine(irregulares[palavra]);
//    }
//    //else if (palavra[^1] == y)
//    else if (palavra.Substring(tamanho - 1, 1) == "y" &&
//        palavra.Substring(tamanho - 2, 1) != "a" &&
//        palavra.Substring(tamanho - 2, 1) != "e" &&
//        palavra.Substring(tamanho - 2, 1) != "i" &&
//        palavra.Substring(tamanho - 2, 1) != "o" &&
//        palavra.Substring(tamanho - 2, 1) != "u")
//    {
//        Console.WriteLine(palavra.Substring(0, tamanho - 1) + "ies");
//    }
//    else if (palavra.Substring(tamanho - 1, 1) == "o" ||
//        palavra.Substring(tamanho - 1, 1) == "s" ||
//        palavra.Substring(tamanho - 1, 1) == "x")
//    {
//        Console.WriteLine(palavra + "es");
//    }
//    else if (palavra.Substring(tamanho - 2, 2) == "ch" ||
//        palavra.Substring(tamanho - 2, 2) == "sh")
//    {
//        Console.WriteLine(palavra + "es");
//    }
//    else
//    {
//        Console.WriteLine(palavra + "s");
//    }
//}