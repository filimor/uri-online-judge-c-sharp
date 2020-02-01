using System;

namespace uri1437 // Esquerda, Volver!
{
    internal static class Program
    {
        private static void Main()
        {
            // 0 = Norte 1 = Leste 2 = Sul 3 = Oeste

            while (Console.ReadLine() != "0")
            {
                int posicao = 0;
                string comandos = Console.ReadLine();

                for (int i = 0; i < comandos.Length; i++)
                {
                    if (comandos[i] == 'D')
                    {
                        posicao++;
                    }
                    else
                    {
                        posicao--;
                    }
                    if (posicao == 4)
                    {
                        posicao = 0;
                    }
                    else if (posicao == -1)
                    {
                        posicao = 3;
                    }
                }

                switch (posicao)
                {
                    case 0:
                        Console.WriteLine("N");
                        break;

                    case 1:
                        Console.WriteLine("L");
                        break;

                    case 2:
                        Console.WriteLine("S");
                        break;

                    case 3:
                        Console.WriteLine("O");
                        break;
                }
            }
        }
    }
}