using System;

namespace uri1914 // De Quem é a Vez?
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int qt);
            for (int i = 0; i < qt; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                string jogador1 = entrada[0];
                string escolha1 = entrada[1];
                string jogador2 = entrada[2];
                string[] numeros = Console.ReadLine().Split(' ');
                int.TryParse(numeros[0], out int numero1);
                int.TryParse(numeros[1], out int numero2);
                if ((numero1 + numero2) % 2 == 0)
                {
                    if (escolha1 == "PAR")
                    {
                        Console.WriteLine(jogador1);
                    }
                    else
                    {
                        Console.WriteLine(jogador2);
                    }
                }
                else
                {
                    if (escolha1 == "IMPAR")
                    {
                        Console.WriteLine(jogador1);
                    }
                    else
                    {
                        Console.WriteLine(jogador2);
                    }
                }
            }
        }
    }
}