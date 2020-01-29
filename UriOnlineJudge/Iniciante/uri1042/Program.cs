using System;

namespace uri1042 // Sort Simples
{
    internal static class Program
    {
        private static void Main()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int numero1);
            int.TryParse(entrada[1], out int numero2);
            int.TryParse(entrada[2], out int numero3);
            int maior, medio, menor;
            if ((numero1 > numero2) && (numero1 > numero3))
            {
                maior = numero1;
                if (numero2 > numero3)
                {
                    medio = numero2;
                    menor = numero3;
                }
                else
                {
                    medio = numero3;
                    menor = numero2;
                }
            }
            else if (numero2 > numero3)
            {
                maior = numero2;
                if (numero1 > numero3)
                {
                    medio = numero1;
                    menor = numero3;
                }
                else
                {
                    medio = numero3;
                    menor = numero1;
                }
            }
            else
            {
                maior = numero3;
                if (numero1 > numero2)
                {
                    medio = numero1;
                    menor = numero2;
                }
                else
                {
                    medio = numero2;
                    menor = numero1;
                }
            }

            Console.WriteLine($"{menor}\n{medio}\n{maior}\n");
            Console.WriteLine($"{numero1}\n{numero2}\n{numero3}");
        }
    }
}