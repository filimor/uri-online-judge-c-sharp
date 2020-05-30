using System;

namespace uri2408 // Vice-Campeão
{
    internal static class Program
    {
        private static void Main()
        {
            string[] str = Console.ReadLine().Split(' ');
            int[] pontuacao = new int[3];
            int.TryParse(str[0], out pontuacao[0]);
            int.TryParse(str[1], out pontuacao[1]);
            int.TryParse(str[2], out pontuacao[2]);
            Array.Sort(pontuacao);
            Console.WriteLine(pontuacao[1]);
        }
    }
}