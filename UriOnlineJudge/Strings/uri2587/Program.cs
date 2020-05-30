using System;

namespace uri2587 // Jetiqui
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int c);
            for (int i = 0; i < c; i++)
            {
                string duvida1 = Console.ReadLine();
                string duvida2 = Console.ReadLine();
                string palavra = Console.ReadLine();
                int posicao1 = -1;
                int posicao2 = -1;

                for (int j = 0; j < palavra.Length; j++)
                {
                    if (palavra[j] == '_')
                    {
                        if (posicao1 == -1)
                        {
                            posicao1 = j;
                        }
                        else
                        {
                            posicao2 = j;
                        }
                    }
                }

                Console.WriteLine((duvida1[posicao1] == duvida2[posicao2] ||
                    duvida1[posicao2] == duvida2[posicao1]) ? "Y" : "N");
            }
        }
    }
}