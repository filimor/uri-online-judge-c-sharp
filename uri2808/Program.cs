using System;

namespace uri2808 // Mais Cavalos
{
    internal static class Program
    {
        private static void Main()
        {
            string str = Console.ReadLine();
            int colunaOrigem = NumeroColuna(str[0]);
            int.TryParse(str[1].ToString(), out int linhaOrigem);
            int colunaDestino = NumeroColuna(str[3]);
            int.TryParse(str[4].ToString(), out int linhaDestino);

            if ((colunaDestino == colunaOrigem - 1 && linhaDestino == linhaOrigem - 2) ||
                (colunaDestino == colunaOrigem - 2 && linhaDestino == linhaOrigem - 1) ||
                (colunaDestino == colunaOrigem - 2 && linhaDestino == linhaOrigem + 1) ||
                (colunaDestino == colunaOrigem - 1 && linhaDestino == linhaOrigem + 2) ||
                (colunaDestino == colunaOrigem + 1 && linhaDestino == linhaOrigem - 2) ||
                (colunaDestino == colunaOrigem + 2 && linhaDestino == linhaOrigem - 1) ||
                (colunaDestino == colunaOrigem + 2 && linhaDestino == linhaOrigem + 1) ||
                (colunaDestino == colunaOrigem + 1 && linhaDestino == linhaOrigem + 2))
            {
                Console.WriteLine("VALIDO");
            }
            else
            {
                Console.WriteLine("INVALIDO");
            }
        }

        private static int NumeroColuna(char c)
        {
            return c switch
            {
                'a' => 1,
                'b' => 2,
                'c' => 3,
                'd' => 4,
                'e' => 5,
                'f' => 6,
                'g' => 7,
                'h' => 8,
                _ => 0,
            };
        }
    }
}