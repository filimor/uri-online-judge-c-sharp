using System;

namespace uri1430
{
    internal static class ComposicaoDeJingles
    {
        private static void Main()
        {
            string[] compasso = Console.ReadLine().Split('/');
            while (compasso[0] != "*")
            {
                int resultado = 0;

                for (int i = 0; i < compasso.Length; i++)
                {
                    int duracao = 0;

                    foreach (char caractere in compasso[i])
                    {
                        switch (caractere)
                        {
                            case 'W':
                                duracao += 64;
                                break;

                            case 'H':
                                duracao += 32;
                                break;

                            case 'Q':
                                duracao += 16;
                                break;

                            case 'E':
                                duracao += 8;
                                break;

                            case 'S':
                                duracao += 4;
                                break;

                            case 'T':
                                duracao += 2;
                                break;

                            case 'X':
                                duracao++;
                                break;
                        }
                    }

                    if (duracao == 64)
                    {
                        resultado++;
                    }
                }

                Console.WriteLine(resultado);
                compasso = Console.ReadLine().Split('/');
            }
        }
    }
}